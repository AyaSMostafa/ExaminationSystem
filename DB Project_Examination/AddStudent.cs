using DB_Project_Examination.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    public partial class AddStudent : Form
    {
        Examination_Context db;
        public AddStudent()
        {
            InitializeComponent();
            db = new Examination_Context();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            var students = db.Students.Select(n => new { n.st_id, n.st_fname, n.age, n.Department.dept_name }).ToList();
            combo_dept.DisplayMember = "dept_name";
            combo_dept.ValueMember = "dept_id";
            combo_dept.DataSource = db.Departments.ToList();
            List<string> Gender = new List<string>() { "F", "M" };
            combo_gender.DataSource = Gender;
        }
        public void Reset_Error()
        {
            Errors.SetError(txt_fname, "");
            Errors.SetError(txt_lname, "");
            Errors.SetError(txt_pass, "");
            Errors.SetError(numericUpDown1, "");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Match Fname = Regex.Match(txt_fname.Text, "^[a-z A-Z]*$", RegexOptions.IgnoreCase);
            Match lName = Regex.Match(txt_lname.Text, "^[a-z A-Z]*$", RegexOptions.IgnoreCase);
            Reset_Error();
            bool error = true;
            if (!Fname.Success)
            {
                error = false;
                Errors.SetError(txt_fname, "First name should be Char only");
            }
            if (!lName.Success)
            {
                error = false;
                Errors.SetError(txt_lname, "Last name should be Char only");
            }
            if (txt_fname.Text == "")
            {
                error = false;
                Errors.SetError(txt_fname, "First name is required");
            }
            if (txt_lname.Text == "")
            {
                error = false;
                Errors.SetError(txt_lname, "Last name is required");
            }
            if (txt_pass.Text == "")
            {
                error = false;
                Errors.SetError(txt_pass, "Password name is required");
            }
            if (numericUpDown1.Value == 0)
            {
                error = false;
                Errors.SetError(numericUpDown1, "Age Can't be Zero");
            }

            if (error)
            {
                Student stu = new Student()
                {
                    st_fname = txt_fname.Text,
                    st_lname = txt_lname.Text,
                    age = (int)numericUpDown1.Value,
                    dept_id = (int)combo_dept.SelectedValue,
                    gender = combo_gender.Text,
                    password = txt_pass.Text,
                };
                db.Students.Add(stu);
                Reset_Error();
                Valid_error.Text = "Success!";
                db.SaveChanges();
            }
        }


        private void btn_cancl_Click(object sender, EventArgs e)
        {

            txt_fname.Text = " ";
            txt_lname.Text = " ";
            txt_pass.Text = " ";
            numericUpDown1.Value = 0;
            combo_dept.SelectedValue = 1;
            combo_gender.SelectedValue = 1;
        }
    }
}
