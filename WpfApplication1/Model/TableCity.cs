namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableCity")]
    public partial class TableCity
    {
        [Key]
        public int CityId { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }
    }
}
