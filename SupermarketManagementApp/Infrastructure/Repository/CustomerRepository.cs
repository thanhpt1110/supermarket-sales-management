using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class CustomerRepository: GenericRepository<Customer>
    {
        public CustomerRepository():base() { }
        public CustomerRepository(SupermarketContext context) : base(context) { }

    }
}
