namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shelf")]
    public partial class Shelf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shelf()
        {
            ShelfDetails = new HashSet<ShelfDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShelfID { get; set; }

        public int ShelfFloor { get; set; }

        public int ProductTypeID { get; set; }  

        public int LayerQuantity { get; set; }

        public int LayerCapacity { get; set; }

        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShelfDetail> ShelfDetails { get; set; }
        public virtual ProductType ProductType { get; set; }

    }
}
