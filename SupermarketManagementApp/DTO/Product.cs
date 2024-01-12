namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            CustomerInvoiceDetails = new HashSet<CustomerInvoiceDetail>();
            InventoryDetails = new HashSet<InventoryDetail>();
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetail>();
        }

        public long? ProductID { get; set; }

        public int? ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        public string WholeSaleUnit { get; set; }

        public string RetailUnit { get; set; }

        public int UnitConversion { get; set; }

        public string PreservationType { get; set; }

        public int ProductCapacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerInvoiceDetail> CustomerInvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryDetail> InventoryDetails { get; set; }

        public virtual ProductType ProductType { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierInvoiceDetail> SupplierInvoiceDetails { get; set; }
    }
}
