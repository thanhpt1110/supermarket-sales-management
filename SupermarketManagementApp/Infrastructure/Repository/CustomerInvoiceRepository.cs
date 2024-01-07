using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class CustomerInvoiceRepository: GenericRepository<CustomerInvoice>
    {
        public CustomerInvoiceRepository():base() { 
        }
        public CustomerInvoiceRepository(SupermarketContext context) : base(context)
        {
        }
        public override async Task<CustomerInvoice> Add(CustomerInvoice entity)
        {
            try
            {
                var customerInvoice = await base.Add(entity);
                entity.DatePayment = DateTime.Now;
                entity.TotalAmount = 0;
                foreach (CustomerInvoiceDetail customerInvoiceDetail in entity.CustomerInvoiceDetails)
                {
                    context.CustomerInvoiceDetails.Add(customerInvoiceDetail);
                    entity.TotalAmount += customerInvoiceDetail.Product.UnitPrice * customerInvoiceDetail.ProductQuantity;
                }
                await context.SaveChangesAsync();
                return customerInvoice;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override Task<IEnumerable<CustomerInvoice>> Find(Expression<Func<CustomerInvoice, bool>> predicate)
        {
            try
            {
                return base.Find(predicate);
            }
            catch { throw; }
        }
        public override async Task<CustomerInvoice> FindByID(long id)
        {
            try
            {
                var customerInvoice = await base.FindByID(id);
                if (customerInvoice == null)
                    throw new NotExistedObjectException("Customer invoice is not existed");
                return customerInvoice;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public override Task<IEnumerable<CustomerInvoice>> GetAll()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                throw;
            }
        }
        public override async Task<bool> RemoveByID(long id)
        {
            try
            {
                var customerInvoice = await base.FindByID(id);
                if (customerInvoice == null)
                    throw new NotExistedObjectException("Customer invoice is not existed");
                foreach (var invoiceDetail in customerInvoice.CustomerInvoiceDetails)
                {
                    var existingDetail = context.CustomerInvoiceDetails.Find(invoiceDetail.CustomerInvoiceDetailID);

                    if (existingDetail != null)
                    {
                        context.CustomerInvoiceDetails.Remove(existingDetail);
                    }
                }
                await context.SaveChangesAsync();
                return await base.RemoveByID(id);
            }
            catch { throw; }
        }
        public override async Task<CustomerInvoice> Update(CustomerInvoice entity)
        {
            try
            {
                var existingInvoice = await base.FindByID(entity.CustomerInvoiceID);
                if (existingInvoice == null)
                {
                    throw new NotExistedObjectException("Customer invoice is not existed");
                }

                foreach (var existingDetail in existingInvoice.CustomerInvoiceDetails.ToList())
                {
                    if (!entity.CustomerInvoiceDetails.Any(d => d.CustomerInvoiceDetailID == existingDetail.CustomerInvoiceDetailID))
                    {
                        existingInvoice.TotalAmount -= existingDetail.Product.UnitPrice * existingDetail.ProductQuantity;
                        context.CustomerInvoiceDetails.Remove(existingDetail);
                    }
                }

                // Kiểm tra và cập nhật hoặc thêm mới các chi tiết Invoice
                foreach (var updatedDetail in entity.CustomerInvoiceDetails)
                {
                    var existingDetail = existingInvoice.CustomerInvoiceDetails.FirstOrDefault(d => d.CustomerInvoiceDetailID == updatedDetail.CustomerInvoiceDetailID);

                    if (existingDetail != null)
                    {
                        existingDetail.ProductID = updatedDetail.ProductID;
                        // Cập nhật chi tiết Invoice
                        // (Bạn cần cập nhật các trường thông tin của chi tiết Invoice tại đây)
                    }
                    else
                    {
                        // Thêm mới chi tiết Invoice
                        existingInvoice.CustomerInvoiceDetails.Add(updatedDetail);
                    }
                }

                await context.SaveChangesAsync();
                return await base.Update(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}
