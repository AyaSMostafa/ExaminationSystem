using DB_Project_Examination.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    public partial class AddQuestion_Form : Form
    {
        Examination_Context db;
        List<Ques_Choice> choices;
        int index = 1;

        public AddQuestion_Form()
        {
            InitializeComponent();
            db = new Examination_Context();
            choices = new List<Ques_Choice>();
        }

        private void AddQuestion_Form_Load(object sender, EventArgs e)
        {
            //Hiding Question Details 
            lbl_qType.Visible = false;
            cb_qType.Visible = false;
            panel_Question.Visible = false;

            //Filling Courses ComboBox
            var courses = db.Courses.Select(c => new { Course_ID = c.crs_id, Course_Name = c.crs_name }).ToList();
            cb_courselist.DataSource = courses;
            cb_courselist.DisplayMember = "Course_Name";
            cb_courselist.ValueMember = "Course_ID";

        }

        private void cb_courselist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Showing Question Details on Selecting Course
            lbl_qType.Visible = true;
            cb_qType.Visible = true;

            //Filling Question Type ComboBox
            cb_qType.DataSource = Enum.GetValues(typeof(qType));
        }

        private void btn_addChoice_Click(object sender, EventArgs e)
        {
            //Making Sure not to add Empty Choices
            if (rtxt_Choice.Text == "")
            {
                errProvider.SetError(rtxt_Choice, "Insert The Choice");
                return;
            }

            //Adding Choice
            choices.Add(new Ques_Choice { ans_id = index, ques_text = rtxt_Choice.Text });
            index++;

            //Fillind Right Answer ComboBox
            cb_rAns.DataSource = null;
            cb_rAns.DataSource = choices;
            cb_rAns.DisplayMember = "ques_text";
            cb_rAns.ValueMember = "ans_id";

            rtxt_Choice.Text = "";

            //Maximum 4 Choices per Question
            if (index > 4)
                btn_addChoice.Enabled = false;

            MessageBox.Show("Choice Added successfully");

        }

        private void rtxt_Choice_MouseDown(object sender, MouseEventArgs e)
        {
            errProvider.SetError(rtxt_Choice, "");

        }

        private void cb_qType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cb_qType.SelectedValue == (int)qType.TF)
            {
                //Setting Default Choices for T or F 
                qHeader.Text = "TRUE or FALSE questions";
                rtxt_Choice.Text = "Choices for True and False Questions are set By Default";
                rtxt_Choice.Enabled = false;
                btn_addChoice.Enabled = false;

                choices.Add(new Ques_Choice { ans_id = 0, ques_text = "True" });
                choices.Add(new Ques_Choice { ans_id = 1, ques_text = "False" });
            }
            else if ((int)cb_qType.SelectedValue == (int)qType.MCQ)
            {
                //Allowing User to Insert Choices for MCQ
                qHeader.Text = "MCQ questions";
                rtxt_Choice.Text = "";
                rtxt_Choice.Enabled = true;
                btn_addChoice.Enabled = true;
                choices.Clear();
            }
            cb_rAns.DataSource = null;
            cb_rAns.DataSource = choices;
            cb_rAns.DisplayMember = "ques_text";
            cb_rAns.ValueMember = "ans_id";
            panel_Question.Visible = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Creating SQL Parameters
            var cid = new SqlParameter("@cid", (int)cb_courselist.SelectedValue);
            var qType = new SqlParameter("@qType", cb_qType.SelectedValue.ToString());
            var qGrade = new SqlParameter("@qGrade", (int)num_qGrade.Value);
            var qHeaderVar = new SqlParameter("@qHeader", qHeader.Text);
            var qBody = new SqlParameter("@qBody", rtxt_qBody.Text);

            if (rtxt_qBody.Text != "" && 
                choices.Count >= 2 
                && num_qGrade.Value != 0)
            {
                var rAns = new SqlParameter("@rAns", (int)cb_rAns.SelectedValue);
                var firstChoice = new SqlParameter("@firstChoice", choices[0].ques_text.ToString());
                var secondChoice = new SqlParameter("@secondChoice", choices[1].ques_text.ToString());
                var thirdChoice = new SqlParameter("@thirdChoice", String.Empty);
                var fourthChoice = new SqlParameter("@fourthChoice", String.Empty);

                //Calling the Stored Procedure According to Question Type
                if (cb_qType.SelectedValue.ToString() == "TF")
                {
                    db.Database.ExecuteSqlCommand("exec Add_Question @qType,@rAns,@qGrade,@qHeader,@qBody,@cid,@firstChoice, @secondChoice,@thirdChoice,@fourthChoice", qType, rAns, qGrade, qHeaderVar, qBody, cid, firstChoice, secondChoice, thirdChoice, fourthChoice);

                }
                else if (cb_qType.SelectedValue.ToString() == "MCQ")
                {
                    thirdChoice = new SqlParameter("@thirdChoice", choices[2].ques_text.ToString());
                    fourthChoice = new SqlParameter("@fourthChoice", choices[3].ques_text.ToString());

                    db.Database.ExecuteSqlCommand("exec Add_Question @qType,@rAns,@qGrade,@qHeader,@qBody,@cid,@firstChoice, @secondChoice,@thirdChoice,@fourthChoice", qType, rAns, qGrade, qHeaderVar, qBody, cid, firstChoice, secondChoice, thirdChoice, fourthChoice);
                }
                MessageBox.Show("Question Added successfully");
                clearInputs();
            }
            else
            {
                if (rtxt_qBody.Text == "")
                    errProvider.SetError(rtxt_qBody, "Question Body can't be empty");
                if (choices.Count < 2)
                    errProvider.SetError(cb_rAns, "Question Choice can't be less than two");
                if (num_qGrade.Value == 0)
                    errProvider.SetError(num_qGrade, "Question Grade can't be empty");
            }

        }
        void clearInputs()
        {
            rtxt_qBody.Text = rtxt_Choice.Text = "";
            num_qGrade.Value = 0;
            cb_rAns.DataSource = null;
        }

        private void num_qGrade_ValueChanged(object sender, EventArgs e)
        {
            errProvider.SetError(num_qGrade, "");
        }

        private void rtxt_qBody_TextChanged(object sender, EventArgs e)
        {
            errProvider.SetError(rtxt_qBody, "");
        }

        private void cb_rAns_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errProvider.SetError(cb_rAns, "");
        }
    }

    enum qType
    {
        TF,
        MCQ
    }

}
