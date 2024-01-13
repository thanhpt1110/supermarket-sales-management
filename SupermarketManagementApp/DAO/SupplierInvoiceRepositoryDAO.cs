using SupermarketManagementApp.DTO;
using SupermarketManagementApp.ErrorHandle;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.DAO
{
    public class SupplierInvoiceRepositoryDAO: GenericRepositoryDAO<SupplierInvoice>
    {
        public SupplierInvoiceRepositoryDAO():base() { }
        public SupplierInvoiceRepositoryDAO(SupermarketContext context) : base(context) {}
        public override async Task<SupplierInvoice> Add(SupplierInvoice entity)
        {
            try
            {
                entity.DatePayment = DateTime.Now;
                entity.TotalAmount = 0;
                List<SupplierInvoiceDetail> suppliers = entity.SupplierInvoiceDetails.ToList();
                entity.SupplierInvoiceDetails = null;
                // Add SupplierInvoice to the context
                context.SupplierInvoices.Add(entity);

                // Save changes to get the SupplierInvoiceID generated (assuming it's an auto-increment field)
                await context.SaveChangesAsync();

                // Iterate through SupplierInvoiceDetails
                foreach (SupplierInvoiceDetail supplierInvoiceDetail in suppliers)
                {
                    // Assign SupplierInvoiceID to each SupplierInvoiceDetail
                    supplierInvoiceDetail.SupplierInvoiceID = entity.SupplierInvoiceID;

                    // Add SupplierInvoiceDetail to the context

                    // Update TotalAmount based on SupplierInvoiceDetails
                    entity.TotalAmount += supplierInvoiceDetail.Product.UnitPrice * supplierInvoiceDetail.ProductQuantity;
                    supplierInvoiceDetail.ProductID = supplierInvoiceDetail.Product.ProductID;
                    supplierInvoiceDetail.Product = null;
                    context.SupplierInvoiceDetails.Add(supplierInvoiceDetail);
                }
                context.SupplierInvoices.AddOrUpdate(entity);
                // Update the SupplierInvoice entity with the calculated TotalAmount
                context.Entry(entity).State = EntityState.Modified;

                // Save changes to persist SupplierInvoiceDetails and update TotalAmount
                await context.SaveChangesAsync();

                return entity;
            }
            catch (DbUpdateException ex)
            {
                // Handle DbUpdateException (thrown by SaveChangesAsync)
                // Log or handle the exception as needed
                // You can inspect ex.InnerException for more details
                Console.WriteLine("DbUpdateException occurred: " + ex.Message);

                // Check the inner exception for more details
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }

                // Rethrow the exception or handle it based on your requirements
                throw;
            }
            catch (Exception ex)
            {
                // Handle exception (log, rethrow, etc.)
                throw;
            }
        }

        public override Task<IEnumerable<SupplierInvoice>> Find(Expression<Func<SupplierInvoice, bool>> predicate)
        {
            try
            {
                return base.Find(predicate);
            }
            catch { throw; }
        }
        public override async Task<SupplierInvoice> FindByID(long id)
        {
            try
            {
                var customerInvoice = await base.FindByID(id);
                if (customerInvoice == null)
                    throw new NotExistedObjectException("Customer invoice is not existed");
                return customerInvoice;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override Task<IEnumerable<SupplierInvoice>> GetAll()
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
                foreach (var invoiceDetail in customerInvoice.SupplierInvoiceDetails)
                {
                    var existingDetail = context.SupplierInvoiceDetails.Find(invoiceDetail.SuppliernvoiceDetailID);

                    if (existingDetail != null)
                    {
                        context.SupplierInvoiceDetails.Remove(existingDetail);
                    }
                }
                await context.SaveChangesAsync();
                return await base.RemoveByID(id);
            }
            catch { throw; }
        }
    }
}
