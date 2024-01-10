using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        private readonly UnitOfWork unitOfWork;

        private CustomerBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static CustomerBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerBUS();
            }
            return instance;
        }
        public async Task<Result<DTO.Customer>> getCustomerByID(long id)
        {
            Result<DTO.Customer> result =  new Result<DTO.Customer>();
            try
            {
                result.Data = await unitOfWork.CustomerRepositoryDAO.FindByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public async Task<Result<DTO.Customer>> getCustomerByPhoneNumber(string phoneNumber)
        {
            Result<DTO.Customer> result = new Result<DTO.Customer>();
            try
            {
                IEnumerable<DTO.Customer> customers = await unitOfWork.CustomerRepositoryDAO.Find(c => c.PhoneNumber == phoneNumber);

                DTO.Customer customer = customers.SingleOrDefault();
                if (customer != null)
                    result.Data = customer;
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
