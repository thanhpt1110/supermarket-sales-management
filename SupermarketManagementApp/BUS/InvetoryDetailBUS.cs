using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class InvetoryDetailBUS
    {
        private static InvetoryDetailBUS instance;
        private readonly UnitOfWork unitOfWork;

        private InvetoryDetailBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static InvetoryDetailBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new InvetoryDetailBUS();
            }
            return instance;
        }
        public async Task<Result<IEnumerable<InventoryDetail>>> getAllInventoryDetail()
        {
            Result<IEnumerable<InventoryDetail>> result = new Result<IEnumerable<InventoryDetail>>();
            try
            {
                result.Data = await unitOfWork.InventoryDetailRepositoryDAO.GetAll();
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
        public async Task<Result<InventoryDetail>> getInventoryByID(long id)
        {
            Result<InventoryDetail> result = new Result<InventoryDetail>();
            try
            {
                result.Data = await unitOfWork.InventoryDetailRepositoryDAO.FindByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch(Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<float>> getCapacityOfInventory()
        {
            Result<float> result = new Result<float>();
            try
            {
                var listInventory = await unitOfWork.InventoryDetailRepositoryDAO.GetAll();
                float capacity = 0;
                foreach( var item in listInventory)
                {
                        capacity += item.ProductQuantity * item.Product.ProductCapacity;
                }
                result.Data = capacity;
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
    }
}
