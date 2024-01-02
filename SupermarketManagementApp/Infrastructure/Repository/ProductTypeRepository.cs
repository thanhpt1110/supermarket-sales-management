using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class ProductTypeRepository: GenericRepository<ProductType>
    {
        public ProductTypeRepository():base() { }
        public ProductTypeRepository(SupermarketContext context) : base(context) { }

    }
}
