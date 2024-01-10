namespace SupermarketManagementApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int AccountID { get; set; }

        public int? EmployeeID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
