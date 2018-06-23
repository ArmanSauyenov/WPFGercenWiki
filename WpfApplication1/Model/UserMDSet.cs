namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMDSet")]
    public partial class UserMDSet
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
