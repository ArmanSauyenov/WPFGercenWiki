namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TablesStopReason")]
    public partial class TablesStopReason
    {
        [Key]
        public int intStopReason { get; set; }

        [StringLength(255)]
        public string strReason { get; set; }

        public bool bitDowntime { get; set; }

        public bool bitUnscheduled { get; set; }

        public bool bitPMStoppages { get; set; }

        public bool bitScheduledRepairsAndOther { get; set; }

        public int intLocationId { get; set; }
    }
}
