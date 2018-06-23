namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMFSet")]
    public partial class UserMFSet
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
