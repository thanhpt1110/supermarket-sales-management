using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.DAO
{
    public class CustomerInvoiceDetailRepositoryDAO : GenericRepositoryDAO<CustomerInvoiceDetail>
    {
        public CustomerInvoiceDetailRepositoryDAO(): base() { }

        public CustomerInvoiceDetailRepositoryDAO(SupermarketContext context) : base(context){ }

        public override Task<IEnumerable<CustomerInvoiceDetail>> GetAll()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                throw;
            }
        }
    }
}
