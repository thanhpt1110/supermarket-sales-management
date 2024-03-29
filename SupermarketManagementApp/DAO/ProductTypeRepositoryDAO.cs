﻿using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace SupermarketManagementApp.DAO
{
    public class ProductTypeRepositoryDAO: GenericRepositoryDAO<ProductType>
    {
        public ProductTypeRepositoryDAO():base() { }
        public ProductTypeRepositoryDAO(SupermarketContext context) : base(context) { }
        public override async Task<ProductType> FindByID(long id)
        {
            try
            {
                var productType = await base.FindByID(id);
                if (productType == null)
                {
                    throw new NotExistedObjectException("Product type is not existed");
                }
                return productType;
            }
            catch
            {
                throw;
            }

        }
        public override async Task<ProductType> Add(ProductType entity)
        {
            try
            {
                return await base.Add(entity);
            }
            catch { throw; }
        }
        public override Task<IEnumerable<ProductType>> Find(Expression<Func<ProductType, bool>> predicate)
        {
            try
            {
                return base.Find(predicate);
            }
            catch
            {
                throw;
            }
        }
        public override Task<IEnumerable<ProductType>> GetAll()
        {
            try
            {
                return base.GetAll();
            }
            catch {
                throw;
            }
        }
        public override async Task<bool> RemoveByID(long id)
        {
            try
            {
                var proudctType = context.ProductTypes.Find(id);
                if(proudctType == null)
                {
                    throw new NotExistedObjectException("Product type is not existed");
                }
                return await base.RemoveByID(id);
            }
            catch
            {
                throw;
            }
        }
        public override async Task<ProductType> Update(ProductType entity)
        {
            try
            {
                var productType = context.ProductTypes.Find(entity.ProductTypeID);
                if (productType == null)
                {
                    throw new NotExistedObjectException("Product type is not existed");
                }
                if(productType.Products.Count > 0)
                {
                    throw new ObjectDependException("Can not remove this product type");
                }
                productType.ProductTypeName = entity.ProductTypeName;
                productType.MinTemperature = entity.MinTemperature;
                productType.MaxTemperature = entity.MaxTemperature;
                productType.Description = entity.Description;
                context.ProductTypes.AddOrUpdate(productType);
                await context.SaveChangesAsync();
                return entity;
            }
            catch
            {
                throw;
            }
        }
    }
}
