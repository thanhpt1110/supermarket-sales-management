namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShelfDetail")]
    public partial class ShelfDetail
    {
        public int ShelfDetailID { get; set; }

        public int? ShelfID { get; set; }

        public long? ProductID { get; set; }

        public int ProductQuantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Shelf Shelf { get; set; }
    }
}
