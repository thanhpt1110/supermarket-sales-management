using SupermarketManagementApp.Infrastructure;
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
    }
}
