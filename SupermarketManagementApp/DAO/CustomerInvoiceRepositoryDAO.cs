using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
namespace SupermarketManagementApp.DAO
{
    public class CustomerInvoiceRepositoryDAO: GenericRepositoryDAO<CustomerInvoice>
    {
        public CustomerInvoiceRepositoryDAO():base() { 
        }
        public CustomerInvoiceRepositoryDAO(SupermarketContext context) : base(context)
        {
        }
        public override async Task<CustomerInvoice> Add(CustomerInvoice entity)
        {
            try
            {
                entity.DatePayment = DateTime.Now;
                entity.TotalAmount = 0;
                List<CustomerInvoiceDetail> list = entity.CustomerInvoiceDetails.ToList();
                entity.CustomerInvoiceDetails = null;
                context.CustomerInvoices.Add(entity);
                // Save changes to get the SupplierInvoiceID generated (assuming it's an auto-increment field)
                await context.SaveChangesAsync();
                foreach (CustomerInvoiceDetail customerInvoiceDetail in list)
                {
                    customerInvoiceDetail.CustomerInvoiceID = entity.CustomerInvoiceID;
                    customerInvoiceDetail.CustomerInvoice = null;
                    entity.TotalAmount += customerInvoiceDetail.Product.UnitPrice * customerInvoiceDetail.ProductQuantity;
                    customerInvoiceDetail.Product = null;
                    context.CustomerInvoiceDetails.Add(customerInvoiceDetail);


                }
                await context.SaveChangesAsync();
                return entity;
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
        public override async Task<IEnumerable<CustomerInvoice>> GetAll()
        {
            try
            {
                return await base.GetAll();
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
