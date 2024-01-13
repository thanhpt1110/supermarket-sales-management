namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductType")]
    public partial class ProductType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductType()
        {
            Products = new HashSet<Product>();
            Shelves = new HashSet<Shelf>();
        }

        public int ProductTypeID { get; set; }

        public string ProductTypeName { get; set; }

        public string Description { get; set; }

        public int? MinTemperature { get; set; }

        public int? MaxTemperature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Shelf> Shelves { get; set; }

    }
}
