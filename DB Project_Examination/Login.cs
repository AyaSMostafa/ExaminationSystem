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
    public partial class Login : Form
    {

        public bool IsStudent { get; set; }
        Examination_Context db;
        public Login(bool User_Check)
        {
            InitializeComponent();
            IsStudent = User_Check;
            db = new Examination_Context(); 
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            //((this.ParentForm) as Welcome_Form).formload(new Student_Form(3));
            
            {
                int user_id;
                if (txt_username.Text != "" && txt_pass.Text != "")
                {
                    if (IsStudent)
                    {

                         user_id = db.Students.Where(s => ((s.st_fname + s.st_lname).ToLower() == txt_username.Text.ToLower()) & s.password == txt_pass.Text).Select(s => s.st_id).SingleOrDefault();
                    }else
                    {
                         user_id = db.Instructors.Where(s => s.ins_name.ToLower() == txt_username.Text.ToLower() & s.password == txt_pass.Text).Select(s => s.ins_id).SingleOrDefault();
                    }
                    if(user_id != 0)
                    {
                        if (IsStudent)
                        {
                            ((this.ParentForm) as Welcome_Form).formload(new Student_Form(user_id));
                        }else
                        {
                            ((this.ParentForm) as Welcome_Form).formload(new Control_Instructor());
                        }
                            
                        pass_error.Text = "";
                    }else
                    {
                        pass_error.Text = "Invalid User";
                    }                  
                 }else
                {
                    pass_error.Text = "User Name and Password are required";
                }
            }
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txt_username.Text = "";
                txt_pass.Text = "";
                pass_error.Text = "";
                user_eror.Text = "";
            }
        }
    }
}
