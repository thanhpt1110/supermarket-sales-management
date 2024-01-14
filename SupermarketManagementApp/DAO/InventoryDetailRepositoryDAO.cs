using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace SupermarketManagementApp.DAO
{
    public class InventoryDetailRepositoryDAO: GenericRepositoryDAO<InventoryDetail>
    {
        public InventoryDetailRepositoryDAO():base() { }
        public InventoryDetailRepositoryDAO(SupermarketContext context) : base(context) { }
        public override async Task<InventoryDetail> Update(InventoryDetail entity)
        {
            try
            {
                var inventoryDetail = await context.InventoryDetails.FindAsync(entity.InventoryDetailID);
                if (inventoryDetail == null)
                {
                    throw new NotExistedObjectException("Invetory detail is not existed");
                }
                if(entity.ProductQuantity != inventoryDetail.ProductQuantity)
                {
                    inventoryDetail.ProductQuantity = entity.ProductQuantity;


                }
                inventoryDetail.ProductID = entity.ProductID;
                context.InventoryDetails.AddOrUpdate(inventoryDetail);
                await context.SaveChangesAsync();
                return inventoryDetail;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override async Task<InventoryDetail> AddOrUpdate(InventoryDetail entity)
        {
            try
            {
                var inventoryDetail = await context.InventoryDetails.SingleOrDefaultAsync<InventoryDetail>(p=>p.ProductID == entity.ProductID);
                if(inventoryDetail == null)
                {
                    context.InventoryDetails.Add(entity);
                    await context.SaveChangesAsync();
                    return entity;
                }    
                else
                {
                    inventoryDetail.ProductQuantity += entity.ProductQuantity;
                    context.InventoryDetails.AddOrUpdate(inventoryDetail);
                    await context.SaveChangesAsync();
                    return inventoryDetail;
                }
            }
            catch {
                throw;
            }
        }
        public override async Task<IEnumerable<InventoryDetail>> Find(Expression<Func<InventoryDetail, bool>> predicate)
        {
            try
            {
                return await base.Find(predicate);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public override async Task<IEnumerable<InventoryDetail>> GetAll()
        {
            try
            {
                SupermarketContext context = new SupermarketContext();
                return await context.InventoryDetails.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public override async Task<InventoryDetail> FindByID(long id)
        {
            try
            {
                var inventoryDetail = await context.InventoryDetails.FindAsync(id);
                if (inventoryDetail == null)
                    throw new NotExistedObjectException("Inventory detail not existed");
                return inventoryDetail;
            }
            catch (Exception ex) { throw; }
        }
    }
}
