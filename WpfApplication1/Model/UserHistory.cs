namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistory")]
    public partial class UserHistory
    {
        public int UserHistoryID { get; set; }

        public DateTime? StartDate { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
