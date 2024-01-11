using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Windows;
using System.Data.Entity.Migrations;

namespace SupermarketManagementApp.DAO
{
    internal class ProductRepositoryDAO: GenericRepositoryDAO<Product>
    {
        public ProductRepositoryDAO(SupermarketContext context) : base(context) {
        }
        public ProductRepositoryDAO() : base()
        {
        }
        public override async Task<IEnumerable<Product>> Find(Expression<Func<Product, bool>> predicate)
        {
            try
            {
                return await base.Find(predicate);
            }
            catch (Exception ex) { throw; }
        }
        public override async Task<Product> FindByID(long id)
        {
            try
            {
                var product = await base.FindByID(id);
                if (product == null)
                {
                    throw new NotExistedObjectException("Product is not existed");
                }
                return product;
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
                var product = await context.Products.FindAsync(id);
                if (product == null)
                {
                    throw new NotExistedObjectException("Product is not existed");
                }    
                if(product.CustomerInvoiceDetails.Count>0 || product.SupplierInvoiceDetails.Count>0) {
                    throw new ObjectDependException("Couldn't remove this product");
                }
                return await base.RemoveByID(id);
            }
            catch
            {
                throw;
            }
        }
        public override async Task<Product> Add(Product entity)
        {
            try
            {
                return await base.Add(entity);
            }
            catch (DbUpdateException ex)
            {
                // Check if the exception is due to a unique constraint violation
                if (ExistedObjectException.IsUniqueConstraintViolation(ex))
                {
                    // Handle the unique constraint violation
                    throw new ExistedObjectException("This product name is already existed");
                }
                else
                {
                    throw;
                }
            }
            catch
            {
                throw;
            }
        }
        public override async Task<IEnumerable<Product>> GetAll()
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
        public override async Task<Product> Update(Product entity)
        {
            try
            {
                var product = await context.Products.FindAsync(entity.ProductID);
                if(product == null)
                {
                    throw new NotExistedObjectException("Product is not existed");
                }    
                if(product.ProductName!=entity.ProductName && await context.Products.SingleOrDefaultAsync(p=>p.ProductName == entity.ProductName) != null)
                {
                    throw new ExistedObjectException("Product name is already existed");
                }
                product.ProductName = entity.ProductName;   
                product.ProductTypeID = entity.ProductTypeID;
                product.UnitPrice = entity.UnitPrice;
                product.ProductCapacity = entity.ProductCapacity;
                product.WholeSaleUnit = entity.WholeSaleUnit;
                product.ProductCapacity = entity.ProductCapacity;
                product.RetailUnit = entity.RetailUnit;
                product.UnitConversion = entity.UnitConversion;
                context.Products.AddOrUpdate(product);

                await context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException ex)
            {
                // Check if the exception is due to a unique constraint violation
                if (ExistedObjectException.IsUniqueConstraintViolation(ex))
                {
                    // Handle the unique constraint violation
                    throw new ExistedObjectException("This product name is already existed");
                }
                else
                {
                    throw;
                }
            }
            catch { throw; }
        }

        
    }
}
