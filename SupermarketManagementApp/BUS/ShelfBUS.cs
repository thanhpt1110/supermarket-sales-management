using SupermarketManagementApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class ShelfBUS
    {
        private static ShelfBUS instance;
        private readonly UnitOfWork unitOfWork;

        private ShelfBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static ShelfBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new ShelfBUS();
            }
            return instance;
        }
    }
}
