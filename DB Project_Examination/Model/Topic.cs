namespace DB_Project_Examination.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string topic_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int crs_id { get; set; }

        public virtual Course Course { get; set; }
    }
}
