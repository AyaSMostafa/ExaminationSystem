using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            List <ReportsPaths> reportsPaths = new List<ReportsPaths>()
            {
                new ReportsPaths("/Report/CourseTopics","The Course topics"),
                new ReportsPaths("/Report/DeptSrudents","The students information according to Department"),
                new ReportsPaths("/Report/InstructorDepartment","The courses that instructor teaches"),
                new ReportsPaths("/Report/StudGrade","The grades of the student in all courses"),
                new ReportsPaths("/Report/ExamQuestions","the Questions in Exam and chocies "),
                new ReportsPaths("/Report/ExamQuestionStudentAnswers","the Questions in Exam with the student answers")
            };
            cb_selectReport.DataSource = reportsPaths;
            cb_selectReport.DisplayMember = "choice";
            cb_selectReport.ValueMember = "reportPath";
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            this.rv_displayReport.ServerReport.ReportPath = "/Report/CourseTopics";
            this.rv_displayReport.RefreshReport();
        }

        private void cb_selectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rv_displayReport.ServerReport.ReportPath = cb_selectReport.SelectedValue.ToString();
            this.rv_displayReport.RefreshReport();
        }
    }

    public class ReportsPaths
    {
        public string reportPath { get; set; }

        public string choice { get; set; }
        public ReportsPaths(string path,string choice)
        {
            this.reportPath = path;
            this.choice = choice;
        }
    }
}
