namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierInvoice")]
    public partial class SupplierInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierInvoice()
        {
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetail>();
        }

        [Key]
        public long? SupplierInvoiceID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime DatePayment { get; set; }

        public string SupplierName { get; set; }

        public double TotalAmount { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierInvoiceDetail> SupplierInvoiceDetails { get; set; }
    }
}
