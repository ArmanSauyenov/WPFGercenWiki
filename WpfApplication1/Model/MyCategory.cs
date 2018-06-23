namespace WpfApplication1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyCategory")]
    public partial class MyCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MyCategory()
        {
            MyPersone = new HashSet<MyPersone>();
        }

        public int MyCategoryId { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string URLmYCATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyPersone> MyPersone { get; set; }
    }
}
