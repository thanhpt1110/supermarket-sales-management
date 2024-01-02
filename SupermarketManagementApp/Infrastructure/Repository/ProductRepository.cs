using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    internal class ProductRepository: GenericRepository<Product>
    {
        public ProductRepository(SupermarketContext context) : base(context) {
        }
        public ProductRepository() : base()
        {
        }

    }
}
