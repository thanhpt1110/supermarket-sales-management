namespace SupermarketManagementApp.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            CustomerInvoices = new HashSet<CustomerInvoice>();
        }

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(20)]
        [Index(IsUnique = true)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerInvoice> CustomerInvoices { get; set; }
    }
}
