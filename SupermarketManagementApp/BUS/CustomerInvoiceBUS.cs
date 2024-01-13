using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Infrastructure;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                List<ShelfDetail> shelfDetails = new List<ShelfDetail>();
                foreach(CustomerInvoiceDetail customerInvoiceDetail in customerInvoice.CustomerInvoiceDetails)
                {
                    customerInvoiceDetail.ProductID = customerInvoiceDetail.Product.ProductID;
                    IEnumerable<ShelfDetail> result2 = await unitOfWork.ShelfDetailRepositoryDAO.Find(p => p.ProductID == customerInvoiceDetail.ProductID && p.ProductQuantity >= customerInvoiceDetail.ProductQuantity);
                    if(result2.Any())
                    {
                        result2.First().ProductQuantity -= customerInvoiceDetail.ProductQuantity;
                        shelfDetails.Add(result2.First());
                    }
                    else
                    {
                        result.IsSuccess = false;
                        result.ErrorMessage = customerInvoiceDetail.Product.ProductName + " is not enough";
                        return result;
                    }
                }
                foreach(ShelfDetail shelf in shelfDetails)
                {
                    shelf.Product = null;
                    shelf.Shelf = null;
                    await unitOfWork.ShelfDetailRepositoryDAO.Update(shelf);
                }
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
        public async Task<Result<CustomerInvoice>> AddNewCustomerInvoice(Dictionary<string, CustomerInvoiceDetail> productDictionary, int idCustomer)
        {

            Result<CustomerInvoice> result = new Result<CustomerInvoice>();
            try
            {
                if (idCustomer==0)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = "Please enter all required information";
                    return result;
                }

                List<CustomerInvoiceDetail> customerInvoiceDetails = new List<CustomerInvoiceDetail>();
                if (productDictionary.Count > 0)
                {
                    foreach (var kval in productDictionary)
                    {
                        if (kval.Value.Product == null)
                        {
                            result.IsSuccess = false;
                            result.ErrorMessage = "Please add all required information";
                            return result;
                        }
                        if (customerInvoiceDetails.FirstOrDefault(p => p.Product.ProductName == kval.Value.Product.ProductName) != null)
                        {
                            string message = String.Format("There are duplicate product {0}", kval.Value.Product.ProductName);
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result.IsSuccess = false;
                            result.ErrorMessage = message;
                            return result;
                        }
                        customerInvoiceDetails.Add(kval.Value);
                    }
                }
                DTO.CustomerInvoice customerInvoice = new DTO.CustomerInvoice();
                customerInvoice.EmployeeID = 1;
                customerInvoice.CustomerID = idCustomer;
                customerInvoice.CustomerInvoiceDetails = customerInvoiceDetails;
                try
                {
                    result.Data = await unitOfWork.CustomerInvoiceRepositoryDAO.Add(customerInvoice);
                    result.ErrorMessage = string.Empty;
                    result.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    result.IsSuccess = false;
                    result.ErrorMessage = ex.Message;
                }
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
