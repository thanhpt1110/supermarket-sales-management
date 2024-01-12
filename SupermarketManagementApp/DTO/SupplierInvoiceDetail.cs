namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierInvoiceDetail")]
    public partial class SupplierInvoiceDetail
    {
        [Key]
        public long SuppliernvoiceDetailID { get; set; }

        public long? SupplierInvoiceID { get; set; }

        public long? ProductID { get; set; }

        public int ProductQuantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual SupplierInvoice SupplierInvoice { get; set; }
    }
}
