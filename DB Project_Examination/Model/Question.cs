namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Ques_Choice = new HashSet<Ques_Choice>();
            Std_ans = new HashSet<Std_ans>();
        }

        [Key]
        public int ques_id { get; set; }

        [Required]
        [StringLength(5)]
        public string ques_type { get; set; }

        public int right_ans { get; set; }

        public int ques_grade { get; set; }

        [Required]
        [StringLength(150)]
        public string ques_header { get; set; }

        [Required]
        [StringLength(500)]
        public string ques_body { get; set; }

        public int crs_id { get; set; }

        public int? exam_id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Course Course1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ques_Choice> Ques_Choice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Std_ans> Std_ans { get; set; }
    }
}
