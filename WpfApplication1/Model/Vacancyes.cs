namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vacancyes
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        [StringLength(400)]
        public string link { get; set; }

        [StringLength(400)]
        public string DescriptionText { get; set; }

        public DateTime? PUBDATE { get; set; }

        [StringLength(400)]
        public string guid_d { get; set; }

        [StringLength(255)]
        public string author { get; set; }

        public int? CatID { get; set; }

        public virtual Category Category { get; set; }
    }
}
