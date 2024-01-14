using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class ShelfBUS
    {
        private static ShelfBUS instance;
        private readonly UnitOfWork unitOfWork;

        private ShelfBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static ShelfBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new ShelfBUS();
            }
            return instance;
        }
        public async Task<Result<Shelf>> AddShelf(Shelf shelf)
        {
            Result<Shelf> result = new Result<Shelf>();

            if (shelf == null
                || shelf.ShelfFloor == -1
                || shelf.ProductTypeID == 0
                || shelf.LayerQuantity <= 0
                || shelf.LayerCapacity <= 0)
            {
                result.ErrorMessage = "Please provide all required information!";
                result.IsSuccess = false;
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.ShelfRepositoryDAO.Add(shelf);
                    result.IsSuccess = true;
                    if (result.IsSuccess)
                    {

                    }
                }
                catch (Exception ex)
                {
                    result.ErrorMessage = ex.Message;
                    result.IsSuccess = false;
                }
            }
            return result;
        }
        public async Task<Result<IEnumerable<Shelf>>> getAllShelf()
        {
            Result<IEnumerable<Shelf>> result = new Result<IEnumerable<Shelf>>();

            try
            {
                result.Data = await unitOfWork.ShelfRepositoryDAO.GetAll();
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<Shelf>> getShelfByID(int id)
        {
            Result<Shelf> result = new Result<Shelf>();
            try
            {
                result.Data = await unitOfWork.ShelfRepositoryDAO.FindByID(id);
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<List<ShelfDetail>>> updateShelfDetail(List<ShelfDetail> shelfDetails)
        {
            Result<List<ShelfDetail>> result = new Result<List<ShelfDetail>>();
            List<InventoryDetail> inventoryDetails = new List<InventoryDetail>();
            try
            {
                foreach (var shelfDetail in shelfDetails)
                {
                    ShelfDetail oldShelfDetail = await unitOfWork.ShelfDetailRepositoryDAO.FindByID(shelfDetail.ShelfDetailID);
                    int newQuantity = shelfDetail.ProductQuantity - oldShelfDetail.ProductQuantity;
                    if(shelfDetail.Product!=null)
                    {
                        IEnumerable < ShelfDetail > shelfDetails1 = await unitOfWork.ShelfDetailRepositoryDAO.Find(p => p.ProductID == shelfDetail.ProductID);
                        shelfDetail.ProductID = shelfDetail.Product.ProductID;
                        var findShelfDetail = shelfDetails1.FirstOrDefault();
                        if (findShelfDetail != null && findShelfDetail.ShelfID != shelfDetail.ShelfID)
                        {
                            string message = "Product " + shelfDetail.Product.ProductName + " are existed in shelf " + shelfDetail.ShelfID.ToString();
                            result.ErrorMessage = message;
                            result.IsSuccess = false;
                            return result;
                        }    
                    }
                    IEnumerable<InventoryDetail> inventory = await unitOfWork.InventoryDetailRepositoryDAO.Find(p => p.ProductID == oldShelfDetail.ProductID && p.ProductQuantity > newQuantity);
                    if (inventory.Any())
                    {
                        inventory.First().ProductQuantity = inventory.First().ProductQuantity - newQuantity;
                        inventory.First().ProductID  = oldShelfDetail.ProductID;    
                        inventoryDetails.Add(inventory.First());
                    }
                    else
                    {
                        result.ErrorMessage = "This supply is not enough in inventory";
                    }
                }
                foreach (var shelfDetail in shelfDetails)
                {
                    shelfDetail.Product = null;
                    shelfDetail.Shelf = null;
                    await unitOfWork.ShelfDetailRepositoryDAO.Update(shelfDetail);
                }
                foreach (var inventory in inventoryDetails)
                {
                    
                    await unitOfWork.InventoryDetailRepositoryDAO.Update(inventory);
                }
                result.IsSuccess = true;
                result.Data = shelfDetails;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<bool>> deleteShelf(int sheftID)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                IEnumerable<ShelfDetail> shelfDetails = await unitOfWork.ShelfDetailRepositoryDAO.Find(p => p.ShelfID == sheftID);
                if(shelfDetails.FirstOrDefault(p=>p.ProductQuantity>0) != null)
                {
                    result.ErrorMessage = "Shelf still have product on that!";
                    result.IsSuccess = false;
                    return result;
                }    
                foreach(ShelfDetail shelfDetail in shelfDetails)
                {
                    await unitOfWork.ShelfDetailRepositoryDAO.RemoveByID(shelfDetail.ShelfDetailID);
                }    
                result.Data = await unitOfWork.ShelfRepositoryDAO.RemoveByID(sheftID);
                result.IsSuccess = true;
                result.ErrorMessage = null;
                await unitOfWork.SaveChanges();
            }
            catch (Exception e)
            {
                // Xử lý các exception khác nếu cần
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
                result.Data = false;
            }
            return result;
        }
    }
}
