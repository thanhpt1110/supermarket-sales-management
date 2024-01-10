using SupermarketManagementApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.BUS
{
    public class InvetoryDetailBUS
    {
        private static InvetoryDetailBUS instance;
        private readonly UnitOfWork unitOfWork;

        private InvetoryDetailBUS()
        {
            unitOfWork = new UnitOfWork();
        }

        public static InvetoryDetailBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new InvetoryDetailBUS();
            }
            return instance;
        }
    }
}
