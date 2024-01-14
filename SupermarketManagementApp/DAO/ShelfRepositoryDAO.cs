using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Linq.Expressions;
using SupermarketManagementApp.Utils;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Data.Entity.Infrastructure;

namespace SupermarketManagementApp.DAO
{
    public class ShelfRepositoryDAO: GenericRepositoryDAO<Shelf>
    {
        public ShelfRepositoryDAO():base() { }
        public ShelfRepositoryDAO(SupermarketContext context) : base(context) { }
        public override async Task<Shelf> Add(Shelf entity)
        {
            try
            {
                entity.ProductType = await context.ProductTypes.FindAsync(entity.ProductTypeID);
                entity.ShelfID = await getNewShelfID(entity.ShelfFloor);
                context.Shelves.Add(entity);
                await context.SaveChangesAsync();
                for (int i = 0; i < entity.LayerQuantity; i++)
                {
                    ShelfDetail shelfDetail = new ShelfDetail();
                    shelfDetail.ShelfID = (int) entity.ShelfID;
                    shelfDetail.ProductID = null;
                    shelfDetail.ProductQuantity = 0;
                    context.ShelfDetails.Add(shelfDetail);
                }
                await context.SaveChangesAsync();
                return entity;  
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;
            }
            catch (Exception ex)
            {
                context = new SupermarketContext();
                throw;
            }
        }
        private async Task<int> getNewShelfID(int floor)
        {
            var latestShelf = await context.Shelves
                .Where(s => s.ShelfFloor == floor)
                .OrderByDescending(s => s.ShelfID)
                .FirstOrDefaultAsync();

            if (latestShelf == null)
            {
                return floor * 100 + 1;
            }
            return (int) latestShelf.ShelfID + 1;
        }

        public override async Task<Shelf> AddOrUpdate(Shelf entity)
        {
            try
            {
                var shelf = await context.Shelves.FindAsync(entity.ShelfID);
                return shelf == null ? throw new NotExistedObjectException("Shelf is not existed") : await base.AddOrUpdate(entity);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;

            }
            catch (Exception ex)
            {
                context = new SupermarketContext();
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
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;

            }
            catch (Exception e)
            {
                context = new SupermarketContext();
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
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;

            }
            catch {
                context = new SupermarketContext();
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
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;

            }
            catch (Exception e)
            {
                context = new SupermarketContext();
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
            catch (DbUpdateConcurrencyException ex)
            {
                // Xử lý lỗi đồng thời (nếu cần)

                foreach (var entry in ex.Entries)
                {
                    entry.Reload(); // Hoặc entry.State = EntityState.Detached; trước khi lấy lại dữ liệu
                }

                // Thực hiện lại các thao tác
                // ...
                await context.SaveChangesAsync();
                throw;

            }
            catch (Exception e)
            {
                context = new SupermarketContext(); 
                throw;
            }
        }
       
    }
}
