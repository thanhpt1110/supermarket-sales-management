using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class ShelfDetailRepository: GenericRepository<ShelfDetail>
    {
        public ShelfDetailRepository():base() { }
        public ShelfDetailRepository(SupermarketContext context) : base(context) { }
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
                return await base.Update(entity);
            }
            catch
            {
                throw;
            }
        }

    }
}
