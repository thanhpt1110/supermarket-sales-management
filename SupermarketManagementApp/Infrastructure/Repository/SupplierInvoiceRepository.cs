﻿using SupermarketManagementApp.DAO;
using SupermarketManagementApp.ErrorHandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class SupplierInvoiceRepository: GenericRepository<SupplierInvoice>
    {
        public SupplierInvoiceRepository():base() { }
        public SupplierInvoiceRepository(SupermarketContext context) : base(context) {}
        public override async Task<SupplierInvoice> Add(SupplierInvoice entity)
        {
            try
            {
                var customerInvoice = await base.Add(entity);
                entity.DatePayment = DateTime.Now;
                entity.TotalAmount = 0;
                foreach (SupplierInvoiceDetail customerInvoiceDetail in entity.SupplierInvoiceDetails)
                {
                    context.SupplierInvoiceDetails.Add(customerInvoiceDetail);
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
