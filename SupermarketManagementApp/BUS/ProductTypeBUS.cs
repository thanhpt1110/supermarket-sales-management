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
    public class ProductTypeBUS
    {
        private static ProductTypeBUS instance;
        private readonly UnitOfWork unitOfWork;

        private ProductTypeBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static ProductTypeBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductTypeBUS();
            }
            return instance;
        }
        public async Task<Result<DTO.ProductType>> getProductTypeByID(int id)
        {
            Result<DTO.ProductType> result = new Result<DTO.ProductType>();
            try
            {
                result.Data = await unitOfWork.ProductTypeRepositoryDAO.FindByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = null;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<IEnumerable<DTO.ProductType>>> findProductTypeByName(string productTypeName)
        {
            Result<IEnumerable<DTO.ProductType>> result = new Result<IEnumerable<DTO.ProductType>>();
            try
            {
                result.Data = await unitOfWork.ProductTypeRepositoryDAO.Find(productType => productType.ProductTypeName.Contains(productTypeName));
                result.IsSuccess = true;
                result.ErrorMessage = null;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<IEnumerable<ProductType>>> getAllProductType()
        {
            Result<IEnumerable<ProductType>> result = new Result<IEnumerable<ProductType>>();
            try
            {
                result.Data = await unitOfWork.ProductTypeRepositoryDAO.GetAll();
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

        public async Task<Result<DTO.ProductType>> createNewProductType(DTO.ProductType productType)
        {
            Result<DTO.ProductType> result = new Result<DTO.ProductType>();
            if (string.IsNullOrEmpty(productType.ProductTypeName) || string.IsNullOrEmpty(productType.Description) || productType.MinTemperature == 0
                || productType.MaxTemperature == 0)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please provide all required information!";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.ProductTypeRepositoryDAO.Add(productType);
                    result.IsSuccess = true;
                    result.ErrorMessage = null;
                    await unitOfWork.SaveChanges();
                    return result;
                }
                catch (Exception e)
                {
                    // Xử lý các exception khác nếu cần
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
                }
            }
            return result;
        }
        public async Task<Result<DTO.ProductType>> updateProductType(DTO.ProductType productType)
        {
            Result<DTO.ProductType> result = new Result<DTO.ProductType>();
            if (string.IsNullOrEmpty(productType.ProductTypeName) || string.IsNullOrEmpty(productType.Description) || productType.MinTemperature == 0 || productType.MaxTemperature == 0)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please enter all information!";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.ProductTypeRepositoryDAO.Update(productType);
                    result.IsSuccess = true;
                    result.ErrorMessage = null;
                    await unitOfWork.SaveChanges();
                    return result;

                }
                catch (Exception e)
                {
                    // Xử lý các exception khác nếu cần
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                    result.Data = null;
                }
            }
            return result;
        }
        public async Task<Result<bool>> deteleProductType(int productTypeID)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result.Data = await unitOfWork.ProductTypeRepositoryDAO.RemoveByID(productTypeID);
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

        public async Task<Result<ProductType>> findProductTypeByID(int productTypeID)
        {
            Result<ProductType> result = new Result<ProductType>();
            try
            {
                result.Data = await unitOfWork.ProductTypeRepositoryDAO.FindByID(productTypeID);
                result.IsSuccess = true;
                result.ErrorMessage = null;
                await unitOfWork.SaveChanges();
            }
            catch (Exception e)
            {
                // Xử lý các exception khác nếu cần
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
    }
}
