namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Crs_student = new HashSet<Crs_student>();
            Questions = new HashSet<Question>();
            Questions1 = new HashSet<Question>();
            Topics = new HashSet<Topic>();
        }

        [Key]
        public int crs_id { get; set; }

        [Required]
        [StringLength(50)]
        public string crs_name { get; set; }

        public int? hours { get; set; }

        public int? num_mcq { get; set; }

        public int? num_tf { get; set; }

        public int? exam_Full_Grade { get; set; }

        public int ins_id { get; set; }

        public virtual Instructor Instructor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crs_student> Crs_student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
