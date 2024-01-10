using SupermarketManagementApp.Infrastructure;
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
    }
}
