namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyPersone")]
    public partial class MyPersone
    {
        [Key]
        public int PersoneId { get; set; }

        public int? MyCategoryId { get; set; }

        [StringLength(255)]
        public string Category { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        [StringLength(999)]
        public string Portfolya { get; set; }

        public DateTime? datepub { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        public virtual MyCategory MyCategory { get; set; }
    }
}
