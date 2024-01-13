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
    public class CustomerInvoiceDetailBUS
    {
        private static CustomerInvoiceDetailBUS instance;
        private readonly UnitOfWork unitOfWork;

        private CustomerInvoiceDetailBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static CustomerInvoiceDetailBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new CustomerInvoiceDetailBUS();
            }
            return instance;
        }

        public async Task<Result<IEnumerable<CustomerInvoiceDetail>>> getAllCustomerInvoiceDetail()
        {
            Result<IEnumerable<CustomerInvoiceDetail>> result = new Result<IEnumerable<CustomerInvoiceDetail>>();
            try
            {
                result.Data = await unitOfWork.CustomerInvoiceDetailRepositoryDAO.GetAll();
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
    }
}
