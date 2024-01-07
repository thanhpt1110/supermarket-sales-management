using SupermarketManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure.Repository
{
    public class SupplierInvoiceRepository: GenericRepository<SupplierInvoice>
    {
        public SupplierInvoiceRepository():base() { }
        public SupplierInvoiceRepository(SupermarketContext context) : base(context) { }

    }
}
