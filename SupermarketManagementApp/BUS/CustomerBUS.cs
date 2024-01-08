using SupermarketManagementApp.Infrastructure;
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
    }
}
