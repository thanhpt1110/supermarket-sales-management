using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SupermarketManagementApp.DAO
{
    public partial class SupermarketContext : DbContext
    {
        public SupermarketContext()
            : base("name=SupermarketContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerInvoice> CustomerInvoices { get; set; }
        public virtual DbSet<CustomerInvoiceDetail> CustomerInvoiceDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<InventoryDetail> InventoryDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Shelf> Shelves { get; set; }
        public virtual DbSet<ShelfDetail> ShelfDetails { get; set; }
        public virtual DbSet<SupplierInvoice> SupplierInvoices { get; set; }
        public virtual DbSet<SupplierInvoiceDetail> SupplierInvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IdCardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SupplierInvoice>()
                .HasMany(e => e.SupplierInvoiceDetails)
                .WithOptional(e => e.SupplierInvoice)
                .HasForeignKey(e => e.SupllierInvoiceID);
        }

    }
}
