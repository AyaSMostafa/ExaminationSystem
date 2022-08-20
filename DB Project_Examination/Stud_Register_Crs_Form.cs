using DB_Project_Examination.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    public partial class Stud_Register_Crs_Form : Form
    {
        Examination_Context db;
        public Stud_Register_Crs_Form()
        {
            InitializeComponent();
            db = new Examination_Context();
        }

        private void Stud_Register_Crs_Form_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.ToList();
            cb_crs.DataSource = courses;
            cb_crs.DisplayMember = "crs_name";
            cb_crs.ValueMember = "crs_id";
            listBox.Visible = false;
            btn_add.Visible = false;

        }

        private void cb_crs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var crs_id = new SqlParameter("@crs_id", (int)cb_crs.SelectedValue);
            var stud_list = db.Database.SqlQuery<Student>("Stud_Regis_Crs @crs_id", crs_id).ToList();

            listBox.Items.Clear();
            for (int i = 0; i < stud_list.Count; i++)
            {
                listBox.Items.Add(stud_list[i]);

            }
            listBox.Visible = true;

            btn_add.Visible = true;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listBox.CheckedIndices.Count > 0)
            {
                foreach (var item in listBox.CheckedItems)
                {
                    var st_id = new SqlParameter("@st_id", ((Student)item).st_id);
                    var crs_id = new SqlParameter("@crs_id", (int)cb_crs.SelectedValue);
                    db.Database.ExecuteSqlCommand("exec Insert_Crs_student @crs_id, @st_id", crs_id, st_id);
                    MessageBox.Show("Students are added to Course successfully");
                    listBox.Visible=false;
                    label1.Visible = false;
                    cb_crs.SelectedValue = 1;
                }
            }
            else
            {
                MessageBox.Show("Please Select Students First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
