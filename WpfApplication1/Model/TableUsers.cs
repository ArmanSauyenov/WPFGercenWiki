namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TableUsers
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(150)]
        public string Login { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        [StringLength(150)]
        public string lName { get; set; }

        [StringLength(150)]
        public string fName { get; set; }

        public bool? Gender { get; set; }

        [StringLength(150)]
        public string EmailAddress { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        public int? CityId { get; set; }

        [StringLength(50)]
        public string PathToPhoto { get; set; }
    }
}
