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
    public class ProductBUS
    {
        private static ProductBUS instance;
        private readonly UnitOfWork unitOfWork;

        private ProductBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static ProductBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new ProductBUS();
            }
            return instance;
        }
        public async Task<Result<DTO.Product>> getProductByID(int id)
        {
            Result<DTO.Product> result = new Result<DTO.Product>();
            try
            {
                result.Data = await unitOfWork.ProductRepositoryDAO.FindByID(id);
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
        public async Task<Result<IEnumerable<Product>>> getAllProduct()
        {
            Result<IEnumerable<Product>> result = new Result<IEnumerable<Product>>();
            try
            {
                result.Data = await unitOfWork.ProductRepositoryDAO.GetAll();
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
        public async Task<Result<DTO.Product>> createNewProduct(DTO.Product product)
        {
            Result<DTO.Product> result = new Result<DTO.Product>();
            if (string.IsNullOrEmpty(product.ProductName) || product.ProductTypeID == 0 || product.UnitPrice == 0 || product.ProductCapacity == 0
                || string.IsNullOrEmpty(product.WholeSaleUnit) || string.IsNullOrEmpty(product.RetailUnit) || product.UnitConversion == 0)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please provide all required information!";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.ProductRepositoryDAO.Add(product);
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

        public async Task<Result<DTO.Product>> updateProduct(DTO.Product product)
        {
            Result<DTO.Product> result = new Result<DTO.Product>();
            if (string.IsNullOrEmpty(product.ProductName) || product.ProductTypeID == 0 || product.UnitPrice == 0 || product.ProductCapacity == 0
                || string.IsNullOrEmpty(product.WholeSaleUnit) || string.IsNullOrEmpty(product.RetailUnit) || product.UnitConversion == 0)
            {
                result.Data = null;
                result.IsSuccess = false;
                result.ErrorMessage = "Please enter all information";
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.ProductRepositoryDAO.Update(product);
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

    }
}
