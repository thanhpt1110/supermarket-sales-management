namespace SupermarketManagementApp.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryDetail")]
    public partial class InventoryDetail
    {
        [Key]
        [Column("InventoryDetail")]
        public long InventoryDetail1 { get; set; }

        public long? ProductID { get; set; }

        public int? ProductQuantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
