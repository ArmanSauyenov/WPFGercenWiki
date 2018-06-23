namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int? OrderPrice { get; set; }

        [StringLength(50)]
        public string OrderNumber { get; set; }

        public int? UserId { get; set; }

        [StringLength(350)]
        public string User_Name { get; set; }

        [StringLength(50)]
        public string User_Code { get; set; }

        [StringLength(310)]
        public string User_NameEn { get; set; }

        public virtual Table_Customer Table_Customer { get; set; }
    }
}
