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
using System.Data.SqlClient;
namespace DB_Project_Examination
{
    public partial class course : Form
    {
        Examination_Context db;
        public course()
        {
            InitializeComponent();
            db = new Examination_Context();
        }


        private void btn_add_crs_Click(object sender, EventArgs e)

        {
            if (crs_txt.Text == "")
            {
                errors.SetError(crs_txt, "Course Name is required!");

            }
            else
            {
                Course crs = new Course()
                {

                    crs_name = crs_txt.Text

                };

                //hours
                var crs_name = new SqlParameter("@crs_name", crs_txt.Text);
                var ins_id = new SqlParameter("@ins_id", cb_insname.SelectedValue);


                db.Database.ExecuteSqlCommand("exec [dbo].[Insert_Course] @crs_name , @ins_id", crs_name, ins_id);

                MessageBox.Show("Added successfully!");

                db.SaveChanges();

            }

        }

        private void course_Load_1(object sender, EventArgs e)
        {
            cb_insname.DataSource = db.Instructors.Select(i => new { i.ins_id, i.ins_name }).ToList();
            cb_insname.DisplayMember = "ins_name";
            cb_insname.ValueMember = "ins_id";

        }
    }
}
