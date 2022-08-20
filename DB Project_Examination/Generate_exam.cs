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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace DB_Project_Examination
{
    public partial class Generate_exam : Form
    {
        Examination_Context _Context;
        public Generate_exam()
        {
            InitializeComponent();
            _Context = new Examination_Context();
        }

        private void Generate_exam_Load(object sender, EventArgs e)
        {
            //Filling Course ComboBox
            var ex = _Context.Courses.Select(c => new { c.crs_id, c.crs_name }).ToList();
            cb_crs_id.DataSource = ex;
            cb_crs_id.ValueMember = "crs_id";
            cb_crs_id.DisplayMember = "crs_name";
            lbl_duo_ex.Visible = false;
            btn_assign_Ex.Visible = false;
            btn_generate_ex.Visible = false;
            lbl_tf.Visible = false;
            N_TF.Visible = false;
            lbl_mcq.Visible = false;
            N_MCQ.Visible = false;
            lbl_duo_ex.Visible = false;
            duration_Ex.Visible = false;
            date_ex.Visible = false;
            date_exam.Visible = false;


        }

        private void btn_generate_ex_Click(object sender, EventArgs e)
        {
            btn_assign_Ex.Visible = false;
            //validation of number of Questions
            int _N_TF = Convert.ToInt32(Math.Round(N_TF.Value, 0));
            int _N_MCQ = Convert.ToInt32(Math.Round(N_MCQ.Value, 0));
            if ((_N_MCQ + _N_TF) != 12)
            {
                MessageBox.Show(($"Error You Selected {_N_MCQ + _N_TF} Questions !!").ToString());
                errorProvider1.SetError(lbl_error, "Number of Questions must be 12!");
            }
            else
            {
                //  validation of exam duoration
                int _duo_ex = Convert.ToInt32(Math.Round(duration_Ex.Value, 0));
                //errorProvider1.SetError(date_exam, "Correct");
                if (_duo_ex < 0 || _duo_ex > 3)
                {
                    errorProvider1.SetError(lbl_error, "Please Enter a Valid exam duration!");
                }
                else
                {
                    //Generate exam 
                    var crsID = new SqlParameter("@crsId", cb_crs_id.SelectedValue);
                    var numTF = new SqlParameter("@numTF", _N_TF);
                    var numMCQ = new SqlParameter("@numMCQ", _N_MCQ);
                    var duorationEx = new SqlParameter("@duration", _duo_ex);
                    _Context.Database.ExecuteSqlCommand("exec [dbo].[GenerateExam] @crsId, @numTF , @numMCQ ,@duration ", crsID, numTF, numMCQ, duorationEx);
                    MessageBox.Show("Generated successfully!");
                    btn_assign_Ex.Visible = true;
                    date_ex.Visible = true; date_exam.Visible = true;
                }
            }
        }

        private void btn_assign_Ex_Click(object sender, EventArgs e)
        {
            var crsID = new SqlParameter("@crsId", cb_crs_id.SelectedValue);
            var examDate = new SqlParameter("@examDate", date_exam.Value);
            _Context.Database.ExecuteSqlCommand("exec [dbo].[setExamDate] @examDate, @crsID", examDate, crsID);
            MessageBox.Show("Assigned successfully!");
        }

        private void start_generate(object sender, EventArgs e)
        {
            var avilableQuestions = _Context.Questions.Where(q => q.crs_id == (int)cb_crs_id.SelectedValue).ToList();
            var question = avilableQuestions.Where(q => q.exam_id == (int)cb_crs_id.SelectedValue).ToList();
            
            if(avilableQuestions.Count < 12)
            {
                MessageBox.Show("Can not generate exam. Please, Add more questions.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hideGenerateExam();
                btn_generate_ex.Visible = false;
                btn_assign_Ex.Visible = false;
                date_ex.Visible = false; date_exam.Visible = false;
            }
            else
            {
                string message = "Do you want to generate exam?";
                string title = "Generate Exam";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    btn_assign_Ex.Visible = false;
                    lbl_duo_ex.Visible = true;
                    btn_generate_ex.Visible = true;
                    lbl_tf.Visible = true;
                    N_TF.Visible = true;
                    lbl_mcq.Visible = true;
                    N_MCQ.Visible = true;
                    lbl_duo_ex.Visible = true;
                    duration_Ex.Visible = true;
                    btn_assign_Ex.Visible = false;
                    date_ex.Visible = false; 
                    date_exam.Visible = false;

                    N_MCQ.Maximum = avilableQuestions.Where(q => q.ques_type == "MCQ  ").Count();
                    N_TF.Maximum = avilableQuestions.Where(q => q.ques_type.Contains("TF")).Count();
                }
                else
                {
                    string message2 = "Do you want to assign the exam date of the exam?";
                    string title2 = "Assign Exam";
                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                    if (result2 == DialogResult.Yes)
                    {

                        if (question.Count != 0)
                        {
                            date_ex.Visible = true;
                            date_exam.Visible = true;
                            btn_assign_Ex.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, Generate exam first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            date_ex.Visible = false;
                            date_exam.Visible = false;
                            btn_assign_Ex.Visible = false;
                        }
                        btn_generate_ex.Visible = false;
                        hideGenerateExam();
                    }
                }
            }
        }
        void hideGenerateExam()
        {
            lbl_duo_ex.Visible = false;
            btn_generate_ex.Visible = false;
            lbl_tf.Visible = false;
            N_TF.Visible = false;
            lbl_mcq.Visible = false;
            N_MCQ.Visible = false;
            lbl_duo_ex.Visible = false;
            duration_Ex.Visible = false;
        }

        private void N_TF_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(lbl_error, "");
        }

        private void N_MCQ_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(lbl_error, "");
        }

        private void date_exam_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(lbl_error, "");
        }

        private void duration_Ex_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(lbl_error, "");
        }
    }


}

