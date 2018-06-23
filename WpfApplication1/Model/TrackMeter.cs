namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackMeter")]
    public partial class TrackMeter
    {
        [Key]
        public int intMeteredId { get; set; }

        public int intEquipmentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime dMeterDate { get; set; }

        public double intMeterReading { get; set; }

        public double? intHoursHoursOperation { get; set; }

        public double? intTotalMeter { get; set; }

        public bool boolMeterReplaced { get; set; }

        public int intTypeMetered { get; set; }

        public int? intComponentId { get; set; }

        public int? intLocationId { get; set; }
    }
}
