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
    public class CustomerInvoiceBUS
    {
        private static CustomerInvoiceBUS instance;
        private readonly UnitOfWork unitOfWork;

        private CustomerInvoiceBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static CustomerInvoiceBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerInvoiceBUS();
            }
            return instance;
        }
        public async Task<Result<CustomerInvoice>> AddNewCustomerInvoice(CustomerInvoice customerInvoice)
        {
            Result<CustomerInvoice> result = new Result<CustomerInvoice>();

            if (customerInvoice == null)
            {
                result.ErrorMessage = "Please add required information";
                result.IsSuccess = false;
                return result;
            }

            if (customerInvoice.CustomerInvoiceDetails.Count == 0)
            {
                result.ErrorMessage = "Please add your product to the invoice";
                result.IsSuccess = false;
                return result;
            }

            if (customerInvoice.CustomerID == 0 || customerInvoice.EmployeeID == 0)
            {
                result.ErrorMessage = "Please add customer information";
                result.IsSuccess = false;
                return result;
            }
            try
            {
                result.Data = await unitOfWork.CustomerInvoiceRepositoryDAO.Add(customerInvoice);
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
        public async Task<Result<IEnumerable<CustomerInvoice>>> getAllCustomerInvoice()
        {
            Result<IEnumerable<CustomerInvoice>> result = new Result<IEnumerable<CustomerInvoice>>();
            try
            {
                result.Data = await unitOfWork.CustomerInvoiceRepositoryDAO.GetAll();
                result.IsSuccess = true;
                result.ErrorMessage = string.Empty;
            }
            catch(Exception e) 
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
        public async Task<Result<CustomerInvoice>> getCustomerInvoiceDetailByID(long id)
        {
            Result<CustomerInvoice> result = new Result<CustomerInvoice>();
            try
            {
                result.Data = await unitOfWork.CustomerInvoiceRepositoryDAO.FindByID(id);
                result.ErrorMessage = string.Empty;
                result.IsSuccess = true;
            }
            catch(Exception e)
            {
                result.ErrorMessage = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }
    }
}
