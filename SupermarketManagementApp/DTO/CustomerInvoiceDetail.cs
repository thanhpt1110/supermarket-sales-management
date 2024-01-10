namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerInvoiceDetail")]
    public partial class CustomerInvoiceDetail
    {
        public long CustomerInvoiceDetailID { get; set; }

        public long? CustomerInvoiceID { get; set; }

        public long? ProductID { get; set; }

        public int? ProductQuantity { get; set; }

        public virtual CustomerInvoice CustomerInvoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
