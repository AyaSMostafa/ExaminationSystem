namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Crs_student = new HashSet<Crs_student>();
            Std_ans = new HashSet<Std_ans>();
        }

        [Key]
        public int st_id { get; set; }

        [Required]
        [StringLength(50)]
        public string st_fname { get; set; }

        [Required]
        [StringLength(50)]
        public string st_lname { get; set; }

        [Required]
        [StringLength(6)]
        public string gender { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public int dept_id { get; set; }

        public int age { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crs_student> Crs_student { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_ans> Std_ans { get; set; }

        public override string ToString()
        {
            return (st_fname + " " + st_lname);
        }
    }
}
