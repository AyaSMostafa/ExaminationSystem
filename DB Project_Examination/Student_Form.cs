using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Project_Examination.Model;
namespace DB_Project_Examination
{
    public partial class Student_Form : Form
    {
        Examination_Context db;

        public int stud_id { get; set; }
        public Student_Form(int sid)
        {
            
            InitializeComponent();
            db = new Examination_Context();
            stud_id = sid;
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {
            var stud = db.Students.Where(s => s.st_id == stud_id).Select(s => new {FullName = s.st_fname +" "+s.st_lname}).SingleOrDefault();
            User_name.Text = stud.FullName.ToString();
            sadsad.Text = DateTime.Now.ToString();
            var course_list = db.Database.SqlQuery<Course>($"exec getAvailableExam {stud_id}").ToList();
            for (int i = 0; i < course_list.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = course_list[i].crs_name.ToString();
                newButton.Name = "btn_" +course_list[i].crs_id.ToString() ;
                newButton.Visible = true;
                newButton.BackColor = Color.AliceBlue;
                newButton.ForeColor = Color.Black;
                newButton.Height = 50;
                newButton.Click += btn_click;
                List_Box.Controls.Add(newButton);
                newButton.Dock = DockStyle.Top;
                newButton.BringToFront();

            }

          
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            (this.ParentForm as Welcome_Form).formload(new Exam(int.Parse(btn.Name.ToString().Split('_')[1]), stud_id));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.ParentForm as Welcome_Form).formload(new Welcome_Form());

        }

    }
}
