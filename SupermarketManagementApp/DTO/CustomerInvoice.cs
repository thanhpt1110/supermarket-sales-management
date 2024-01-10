namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerInvoice")]
    public partial class CustomerInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerInvoice()
        {
            CustomerInvoiceDetails = new HashSet<CustomerInvoiceDetail>();
        }

        public long CustomerInvoiceID { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? DatePayment { get; set; }

        public double? TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerInvoiceDetail> CustomerInvoiceDetails { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
