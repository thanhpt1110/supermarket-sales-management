using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Linq.Expressions;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class ShelfRepository:GenericRepository<Shelf>
    {
        public ShelfRepository():base() { }
        public ShelfRepository(SupermarketContext context) : base(context) { }
        public override Task<Shelf> Add(Shelf entity)
        {
            try
            {
                return base.Add(entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public override async Task<Shelf> AddOrUpdate(Shelf entity)
        {
            try
            {
                var shelf = await context.Shelves.FindAsync(entity.ShelfID);
                return shelf == null ? throw new NotExistedObjectException("Shelf is not existed") : await base.AddOrUpdate(entity);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public override async Task<IEnumerable<Shelf>> Find(Expression<Func<Shelf, bool>> predicate)
        {
            try
            {
                var shelf = await base.Find(predicate);
                return shelf;
            }
            catch(Exception e)
            {
                throw;  
            }    
        }
        public override async Task<Shelf> FindByID(long id)
        {
            try
            {
                var shelf = await context.Shelves.FindAsync(id);
                return shelf ?? throw new NotExistedObjectException("Shelf is not existed");
            }
            catch {
                throw;
            }
        }
        public override async Task<Shelf> Update(Shelf entity)
        {
            try
            {
                var shelf = await context.Shelves.FindAsync(entity.ShelfID);
                if (shelf == null) throw new NotExistedObjectException("Shelf is not existed");
                return await base.Update(entity);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async override Task<bool> RemoveByID(long id)
        {
            try
            {
                var shelf = await context.Shelves.FindAsync(id);
                if (shelf == null) throw new NotExistedObjectException("Shelf is not existed");
                if (shelf.ShelfDetails.Count > 0)
                    throw new ObjectDependException("Product on shelf is still existed");
                return await base.RemoveByID(id);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
