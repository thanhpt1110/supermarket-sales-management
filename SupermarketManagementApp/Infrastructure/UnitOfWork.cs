using SupermarketManagementApp.DAO;
using SupermarketManagementApp.Infrastructure.Repository;
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
        private IRepository<Customer> customerRepository;
        private IRepository<CustomerInvoice> customerInvoiceRepository;
        private IRepository<Employee> employeeRepository;
        private IRepository<InventoryDetail> inventoryDetailRepository;
        private IRepository<Product> productRepository;
        private IRepository<ProductType> productTypeRepository;
        private IRepository<Shelf> shelfRepository;
        private IRepository<SupplierInvoice> supplierInvoiceRepository;

        public UnitOfWork(SupermarketContext context)
        {
            this.context = context;
        }
        public UnitOfWork() {
            this.context = new SupermarketContext();
        }
        private IRepository<Account> accountRepository;
        public IRepository<Account> AccountRepository
        {
            get
            {
                if (accountRepository == null)
                {
                    accountRepository = new AccountRepository(context);
                }
                return accountRepository;
            }
        }

        public IRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(context);
                }
                return customerRepository;
            }
        }

        public IRepository<CustomerInvoice> CustomerInvoiceRepository
        {
            get
            {
                if (customerInvoiceRepository == null)
                {
                    customerInvoiceRepository = new CustomerInvoiceRepository(context);
                }
                return customerInvoiceRepository;
            }
        }

        public IRepository<Employee> EmployeeRepository
        {
            get
            {
                if (employeeRepository == null)
                {
                    employeeRepository = new EmployeeRepository(context);
                }
                return employeeRepository;
            }
        }

        public IRepository<InventoryDetail> InventoryDetailRepository
        {
            get
            {
                if (inventoryDetailRepository == null)
                {
                    inventoryDetailRepository = new InventoryDetailRepository(context);
                }
                return inventoryDetailRepository;
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(context);
                }
                return productRepository;
            }
        }

        public IRepository<ProductType> ProductTypeRepository
        {
            get
            {
                if (productTypeRepository == null)
                {
                    productTypeRepository = new ProductTypeRepository(context);
                }
                return productTypeRepository;
            }
        }

        public IRepository<Shelf> ShelfRepository
        {
            get
            {
                if (shelfRepository == null)
                {
                    shelfRepository = new ShelfRepository(context);
                }
                return shelfRepository;
            }
        }

        public IRepository<SupplierInvoice> SupplierInvoiceRepository
        {
            get
            {
                if (supplierInvoiceRepository == null)
                {
                    supplierInvoiceRepository = new SupplierInvoiceRepository(context);
                }
                return supplierInvoiceRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
