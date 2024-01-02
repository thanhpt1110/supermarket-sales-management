using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class CustomerInvoiceRepository: GenericRepository<CustomerInvoice>
    {
        public CustomerInvoiceRepository():base() { 
        }
        public CustomerInvoiceRepository(SupermarketContext context) : base(context)
        {
        }

    }
}
