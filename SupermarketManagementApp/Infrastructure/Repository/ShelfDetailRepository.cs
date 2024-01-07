using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class ShelfDetailRepository: GenericRepository<ShelfDetail>
    {
        public ShelfDetailRepository():base() { }
        public ShelfDetailRepository(SupermarketContext context) : base(context) { }

    }
}
