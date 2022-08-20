namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Instructor")]
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int ins_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ins_name { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int dept_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        public virtual Department Department { get; set; }
    }
}
