using SupermarketManagementApp.DAO;
using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure
{
    public interface IUnitOfWork
    {
        IRepositoryDAO<Account> AccountRepositoryDAO { get; }
        IRepositoryDAO<Customer> CustomerRepositoryDAO { get; }
        IRepositoryDAO<CustomerInvoice> CustomerInvoiceRepositoryDAO { get; }
        IRepositoryDAO<Employee> EmployeeRepositoryDAO { get; }
        IRepositoryDAO<InventoryDetail> InventoryDetailRepositoryDAO { get; }
        IRepositoryDAO<Product> ProductRepositoryDAO { get; }
        IRepositoryDAO<ProductType> ProductTypeRepositoryDAO { get; }
        IRepositoryDAO<Shelf> ShelfRepositoryDAO { get; }
        IRepositoryDAO<ShelfDetail> ShelfDetailRepositoryDAO { get; }

        IRepositoryDAO<SupplierInvoice> SupplierInvoiceRepositoryDAO { get; }

        Task SaveChanges();
    }
}
