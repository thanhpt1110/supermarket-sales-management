using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class InventoryDetailRepository: GenericRepository<InventoryDetail>
    {
        public InventoryDetailRepository():base() { }
        public InventoryDetailRepository(SupermarketContext context) : base(context) { }
        public override async Task<InventoryDetail> Update(InventoryDetail entity)
        {
            try
            {
                var inventoryDetail = await context.InventoryDetails.FindAsync(entity.InventoryDetailID);
                if (inventoryDetail == null)
                {
                    throw new NotExistedObjectException("Invetory detail is not existed");
                }
                return await base.Update(entity);
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
                    return await base.Add(entity);
                }    
                else
                {
                    inventoryDetail.ProductQuantity += entity.ProductQuantity;
                    return await base.Update(inventoryDetail);
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
                return await base.GetAll();
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
