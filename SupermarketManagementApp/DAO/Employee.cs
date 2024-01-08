namespace SupermarketManagementApp.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Accounts = new HashSet<Account>();
            CustomerInvoices = new HashSet<CustomerInvoice>();
            SupplierInvoices = new HashSet<SupplierInvoice>();
        }

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public DateTime Birthday { get; set; }

        [StringLength(20)]
        [Index(IsUnique = true)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        [Index(IsUnique = true)]
        public string IdCardNumber { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerInvoice> CustomerInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierInvoice> SupplierInvoices { get; set; }
    }
}
