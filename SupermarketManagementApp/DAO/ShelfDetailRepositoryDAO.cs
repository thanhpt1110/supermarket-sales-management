using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Data.Entity.Migrations;

namespace SupermarketManagementApp.DAO
{
    public class ShelfDetailRepositoryDAO: GenericRepositoryDAO<ShelfDetail>
    {
        public ShelfDetailRepositoryDAO():base() { }
        public ShelfDetailRepositoryDAO(SupermarketContext context) : base(context) { }
        public override async Task UpdateManyAsync(IEnumerable<ShelfDetail> entities)
        {
            try
            {
                if (!entities.Any())
                {
                    return;
                }
                var shelf = await context.Shelves.FindAsync(entities.FirstOrDefault().ShelfID) ?? throw new NotExistedObjectException("Shelf is not existed");
                await base.UpdateManyAsync(entities);
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
                var shelfDetail = await context.ShelfDetails.FindAsync(id);
                if(shelfDetail == null) {
                    throw new NotExistedObjectException("Shelf detail is not existed");
                }
                return  await base.RemoveByID(id);
            }
            catch
            {
                throw;
            }
        }
        public override async Task<ShelfDetail> Update(ShelfDetail entity)
        {
            try
            {
                var shelfDetail = await context.ShelfDetails.FindAsync(entity.ShelfDetailID);

                if (shelfDetail == null)
                {
                    throw new NotExistedObjectException("Shelf detail is not existed");
                }
                shelfDetail.ProductQuantity = entity.ProductQuantity;
                shelfDetail.ProductID = entity.ProductID;
                context.ShelfDetails.AddOrUpdate(shelfDetail);
                await context.SaveChangesAsync();
                return shelfDetail;
            }
            catch
            {
                throw;
            }
        }

    }
}
