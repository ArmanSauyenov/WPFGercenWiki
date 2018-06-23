namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entity1Set
    {
        public int Id { get; set; }

        [Required]
        public string Property1 { get; set; }

        [Required]
        public string Property2 { get; set; }
    }
}
