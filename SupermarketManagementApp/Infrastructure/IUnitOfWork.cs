using SupermarketManagementApp.DAO;
using SupermarketManagementApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepository<Account> AccountRepository { get; }
        IRepository<Customer> CustomerRepository { get; }
        IRepository<CustomerInvoice> CustomerInvoiceRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<InventoryDetail> InventoryDetailRepository { get; }
        IRepository<Product> ProductRepository { get; }
        IRepository<ProductType> ProductTypeRepository { get; }
        IRepository<Shelf> ShelfRepository { get; }
        IRepository<SupplierInvoice> SupplierInvoiceRepository { get; }

        void SaveChanges();
    }
}
