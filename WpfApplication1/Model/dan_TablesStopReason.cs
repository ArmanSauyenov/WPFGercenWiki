namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dan_TablesStopReason
    {
        [Key]
        public int intStopReasonID { get; set; }

        [StringLength(100)]
        public string strReason { get; set; }

        public bool? bitDowntime { get; set; }

        public bool? bitUnsceduled { get; set; }

        public bool? bitPMStopagges { get; set; }

        public bool? bitSceduledRepairsAndOthers { get; set; }

        public int? intLocationID { get; set; }
    }
}
