namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableEquipmentHistory")]
    public partial class TableEquipmentHistory
    {
        [Key]
        public int intEquipmentHistoryId { get; set; }

        public int? intEquipmentID { get; set; }

        public int? intTypeHistory { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dEndDate { get; set; }

        public int? intDaysCount { get; set; }

        public int? intStatys { get; set; }

        public int? intUserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dCahengeDate { get; set; }

        public virtual newEquipment newEquipment { get; set; }
    }
}
