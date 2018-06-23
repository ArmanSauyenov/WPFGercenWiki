namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dan_TablesModel
    {
        [Key]
        public int intModelID { get; set; }

        [StringLength(100)]
        public string strName { get; set; }

        public int? ManufacturerID { get; set; }

        public int? intSMCSFamilyID { get; set; }

        [StringLength(100)]
        public string strImage { get; set; }
    }
}
