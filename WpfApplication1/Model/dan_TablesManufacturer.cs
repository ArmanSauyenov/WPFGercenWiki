namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dan_TablesManufacturer
    {
        [Key]
        public int intManufID { get; set; }

        [StringLength(100)]
        public string strNameManuf { get; set; }
    }
}
