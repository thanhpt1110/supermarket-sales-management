using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    }
}
