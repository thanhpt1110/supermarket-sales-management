using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class InventoryDetailRepository: GenericRepository<InventoryDetail>
    {
        public InventoryDetailRepository():base() { }
        public InventoryDetailRepository(SupermarketContext context) : base(context) { }

    }
}
