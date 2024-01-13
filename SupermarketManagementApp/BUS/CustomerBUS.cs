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
        public async Task<Result<IEnumerable<Customer>>> GetAllCustomer()
        {
            Result<IEnumerable<Customer>> result = new Result<IEnumerable<Customer>>();
            try
            {
                result.Data = await unitOfWork.CustomerRepositoryDAO.GetAll();
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                result.Data = null;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<Customer>> AddCustomer(Customer customer)
        {
            Result<Customer> result = new Result<Customer>();

            if (customer == null   || string.IsNullOrWhiteSpace(customer.PhoneNumber)
                                   || string.IsNullOrWhiteSpace(customer.Gender)
                                   || string.IsNullOrWhiteSpace(customer.CustomerName)
                                   || customer.Birthday == null)
            {
                result.ErrorMessage = "Please provide all required information!";
                result.IsSuccess = false;
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.CustomerRepositoryDAO.Add(customer);
                    result.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    result.ErrorMessage = ex.Message;
                    result.IsSuccess = false;
                }
            }

            return result;
        }
        public async Task<Result<Customer>> updateCustomer(Customer customer)
        {

            Result<Customer> result = new Result<Customer>();

            if (customer == null 
                                   || string.IsNullOrWhiteSpace(customer.PhoneNumber)
                                   || string.IsNullOrWhiteSpace(customer.Gender)
                                   || string.IsNullOrWhiteSpace(customer.CustomerName)
                                   || customer.Birthday == null)
            {
                result.ErrorMessage = "Please provide all required information";
                result.IsSuccess = false;
            }
            else
            {
                try
                {
                    result.Data = await unitOfWork.CustomerRepositoryDAO.Update(customer);
                    result.IsSuccess = true;
                    result.ErrorMessage = string.Empty;
                }
                catch (Exception e)
                {
                    result.ErrorMessage = e.Message;
                    result.IsSuccess = false;
                }
            }
            return result;
        }
        public async Task<Result<bool>> removeCustomerByID(int id)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                result.Data = await unitOfWork.CustomerRepositoryDAO.RemoveByID(id);
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }

        public async Task<Result<IEnumerable<Customer>>> searchCustomerByName(string name)
        {
            Result<IEnumerable<Customer>> result = new Result<IEnumerable<Customer>>();
            try
            {
                result.Data = await unitOfWork.CustomerRepositoryDAO.Find(p => p.CustomerName.Contains(name));
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
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
