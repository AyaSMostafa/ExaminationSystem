namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Crs_student
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Crs_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int st_id { get; set; }

        public double? st_grade { get; set; }

        [Column(TypeName = "date")]
        public DateTime? exam_date { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
