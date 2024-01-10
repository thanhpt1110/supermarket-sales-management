using SupermarketManagementApp.DAO;
using SupermarketManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementApp.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private SupermarketContext context;
        private IRepositoryDAO<Customer> customerRepositoryDAO;
        private IRepositoryDAO<CustomerInvoice> customerInvoiceRepositoryDAO;
        private IRepositoryDAO<Employee> employeeRepositoryDAO;
        private IRepositoryDAO<InventoryDetail> inventoryDetailRepositoryDAO;
        private IRepositoryDAO<Product> productRepositoryDAO;
        private IRepositoryDAO<ProductType> productTypeRepositoryDAO;
        private IRepositoryDAO<Shelf> shelfRepositoryDAO;
        private IRepositoryDAO<SupplierInvoice> supplierInvoiceRepositoryDAO;
        
        private UnitOfWork(SupermarketContext context)
        {
            this.context = context;
        }
        public UnitOfWork() {
            this.context = new SupermarketContext();
        }
        private IRepositoryDAO<Account> accountRepositoryDAO;
        public IRepositoryDAO<Account> AccountRepositoryDAO
        {
            get
            {
                if (accountRepositoryDAO == null)
                {
                    accountRepositoryDAO = new AccountRepositoryDAO(context);
                }
                return accountRepositoryDAO;
            }
        }

        public IRepositoryDAO<Customer> CustomerRepositoryDAO
        {
            get
            {
                if (customerRepositoryDAO == null)
                {
                    customerRepositoryDAO = new CustomerRepositoryDAO(context);
                }
                return customerRepositoryDAO;
            }
        }

        public IRepositoryDAO<CustomerInvoice> CustomerInvoiceRepositoryDAO
        {
            get
            {
                if (customerInvoiceRepositoryDAO == null)
                {
                    customerInvoiceRepositoryDAO = new CustomerInvoiceRepositoryDAO(context);
                }
                return customerInvoiceRepositoryDAO;
            }
        }

        public IRepositoryDAO<Employee> EmployeeRepositoryDAO
        {
            get
            {
                if (employeeRepositoryDAO == null)
                {
                    employeeRepositoryDAO = new EmployeeRepositoryDAO(context);
                }
                return employeeRepositoryDAO;
            }
        }

        public IRepositoryDAO<InventoryDetail> InventoryDetailRepositoryDAO
        {
            get
            {
                if (inventoryDetailRepositoryDAO == null)
                {
                    inventoryDetailRepositoryDAO = new InventoryDetailRepositoryDAO(context);
                }
                return inventoryDetailRepositoryDAO;
            }
        }

        public IRepositoryDAO<Product> ProductRepositoryDAO
        {
            get
            {
                if (productRepositoryDAO == null)
                {
                    productRepositoryDAO = new ProductRepositoryDAO(context);
                }
                return productRepositoryDAO;
            }
        }

        public IRepositoryDAO<ProductType> ProductTypeRepositoryDAO
        {
            get
            {
                if (productTypeRepositoryDAO == null)
                {
                    productTypeRepositoryDAO = new ProductTypeRepositoryDAO(context);
                }
                return productTypeRepositoryDAO;
            }
        }

        public IRepositoryDAO<Shelf> ShelfRepositoryDAO
        {
            get
            {
                if (shelfRepositoryDAO == null)
                {
                    shelfRepositoryDAO = new ShelfRepositoryDAO(context);
                }
                return shelfRepositoryDAO;
            }
        }

        public IRepositoryDAO<SupplierInvoice> SupplierInvoiceRepositoryDAO
        {
            get
            {
                if (supplierInvoiceRepositoryDAO == null)
                {
                    supplierInvoiceRepositoryDAO = new SupplierInvoiceRepositoryDAO(context);
                }
                return supplierInvoiceRepositoryDAO;
            }
        }

        public async Task SaveChanges()
        {
           await context.SaveChangesAsync();
        }
    }
}
