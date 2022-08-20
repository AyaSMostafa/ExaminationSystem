using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DB_Project_Examination.Model
{
    public partial class Examination_Context : DbContext
    {
        public Examination_Context()
            : base("name=Examination_Context")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Crs_student> Crs_student { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Ques_Choice> Ques_Choice { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Std_ans> Std_ans { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.Crs_student)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.crs_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Questions1)
                .WithOptional(e => e.Course1)
                .HasForeignKey(e => e.exam_id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.ques_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Ques_Choice)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Std_ans)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Crs_student)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Std_ans)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
