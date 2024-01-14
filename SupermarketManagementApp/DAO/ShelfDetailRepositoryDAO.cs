using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagementApp.ErrorHandle;
using System.Data.Entity.Migrations;
using System.CodeDom;
using iTextSharp.text.pdf.codec;
using System.Data.Entity.Infrastructure;

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
                context = new SupermarketContext();
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
            catch
            {
                context = new SupermarketContext();
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
                var shelf = context.Shelves.Find(shelfDetail.ShelfID);
                int totalCapacity = 0;
                foreach(ShelfDetail shelfDetail1 in shelf.ShelfDetails) { 
                    if(shelfDetail.ProductID != null)
                    {   
                        totalCapacity += shelfDetail.Product.ProductCapacity * shelfDetail.ProductQuantity;
                    }
                }
                if(totalCapacity == shelf.LayerCapacity * shelf.LayerQuantity)
                {
                    shelf.Status = "Full";
                }
                else
                {
                    shelf.Status = "Available";
                }
                context.Shelves.AddOrUpdate(shelf);
                context.ShelfDetails.AddOrUpdate(shelfDetail);
                await context.SaveChangesAsync();
                return shelfDetail;
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
            catch
            {
                context = new SupermarketContext();
                throw;
            }
        }

    }
}
