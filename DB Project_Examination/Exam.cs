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
    public partial class Exam : Form
    {
        private int Stud_id;
        private int Crs_id;
        Examination_Context db;
        List<ExamQuestion> question;
        int Cursor = 0;
        public Exam(int crs_id , int stud_id)
        {
            InitializeComponent();
            db = new Examination_Context();
            Crs_id = crs_id;
            Stud_id = stud_id;
            pan_wait.Visible = true;
            lbl_waitGrade.Text = "Wait Loading The Exam";
            lbl_grade.Text = "";
        }

        private void Exam_Load(object sender, EventArgs e)
        {   
            loadExamQuestionFromDB();
            loadQuestion();
            loadQuestionList();
            btn_prev.Enabled = false;
            pan_wait.Visible = false;
        }
        
        private void cb_choices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show($"{cb_choices.SelectedValue} {cb_choices.Text}");
            question[Cursor].Stud_Ans = (int)cb_choices.SelectedValue;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            Cursor--;
            if(Cursor == 0) btn_prev.Enabled = false;
            btn_next.Enabled = true;
            loadQuestion();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Cursor++;
            if(Cursor == question.Count-1) btn_next.Enabled = false;
            btn_prev.Enabled = true;
            loadQuestion();
        }
        void loadExamQuestionFromDB()
        {
            var questions = db.Questions.Where(q => q.exam_id == Crs_id).ToList();
            List<int> quesId = new List<int>();
            foreach (var equestion in questions)
            {
                quesId.Add(equestion.ques_id);
            }
            //var mychoices = db.Ques_Choice.Where(c=>quesId.Contains(c.ques_id));

            var examId = new SqlParameter("@examid", Crs_id);
            var mychoices = db.Database.SqlQuery<Ques_Choice>("exec getExamChoices @examid", examId).ToList();
            question = new List<ExamQuestion>();
            for (int i = 0; i < questions.Count; i++)
            {
                question.Add(new ExamQuestion()
                {
                    ques_id = questions[i].ques_id,
                    ques_type = questions[i].ques_type,
                    ques_body = questions[i].ques_body,
                    ques_grade = questions[i].ques_grade,
                    ques_header = questions[i].ques_header,
                    choices = mychoices.Where(c => c.ques_id == questions[i].ques_id).ToList()
                });
            }
        }
        void loadQuestion()
        {
            lbl_quesHead.Text = question[Cursor].ques_header;
            rtb_quesBody.Text = question[Cursor].ques_body;
            lbl_quesMark.Text = question[Cursor].ques_grade.ToString() + " Marks";
            cb_choices.DataSource = question[Cursor].choices;
            cb_choices.DisplayMember = "ques_text";
            cb_choices.ValueMember = "ans_id";
            cb_choices.SelectedValue = question[Cursor].Stud_Ans;
            if (question[Cursor].ques_marked == true)
            {
                btn_review.BackColor = Color.RosyBrown;
            }
            else
            {
                btn_review.BackColor = Color.DarkSlateGray;
            }
        }

        void loadQuestionList()
        {
            for (int i = 0; i < question.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = "Q" + (i + 1);
                newButton.Name = "btn_" + (i + 1);
                newButton.Visible = true;
                newButton.BackColor = Color.AliceBlue;
                newButton.ForeColor = Color.Black;
                newButton.Width = (flp_questionList.Width)/ (question.Count+2);
                newButton.Height = 50;
                newButton.Click += btn_Click;
                newButton.FlatStyle = FlatStyle.Popup;
                flp_questionList.Controls.Add(newButton);
                newButton.Dock = DockStyle.Top;
                newButton.BringToFront();

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Cursor = int.Parse(btn.Name.ToString().Split('_')[1])-1;
            loadQuestion();
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            if(question[Cursor].ques_marked == false)
            {
                flp_questionList.Controls[question.Count - Cursor -1].BackColor = Color.RosyBrown;
                btn_review.BackColor = Color.RosyBrown;
                question[Cursor].ques_marked = true;
                
            }
            else
            {
                flp_questionList.Controls[question.Count - Cursor -1].BackColor = Color.AliceBlue;
                Button btn = sender as Button;
                btn_review.BackColor = Color.DarkSlateGray;
                question[Cursor].ques_marked = false;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool validSubmit = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("ques_id", typeof(Int32));
            dt.Columns.Add("st_id", typeof(Int32));
            dt.Columns.Add("std_ans", typeof(Int32));
            foreach (var ques in question)
            {
                if(ques.ques_marked == true)
                {
                    validSubmit = false;
                }
                dt.Rows.Add(ques.ques_id, Stud_id, ques.Stud_Ans);
            }

            DialogResult result;
            if(!validSubmit)
                result = MessageBox.Show("You have marked questions for review. Are you sure to Submit?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else result = DialogResult.Yes;

            if (result == DialogResult.Yes)
            {
                pan_wait.Visible = true;
                lbl_waitGrade.Text = "Your grage is: ";
                var ansTab = new SqlParameter("@ansTable", SqlDbType.Structured);
                ansTab.Value = dt;
                ansTab.TypeName = "dbo.stud_ansTable";
                db.Database.ExecuteSqlCommand("exec AnswerExam @ansTable",ansTab);
                MessageBox.Show("Answers Were Submited Correctly");

                var stdid = new SqlParameter("@stdid", Stud_id);
                var examId = new SqlParameter("@examId", Crs_id);
                db.Database.ExecuteSqlCommand("exec CorrectExam @stdid,@examid",stdid,examId);

                double? grade = db.Crs_student.Where(c => c.Crs_id == Crs_id & c.st_id == Stud_id).Select(c => c.st_grade).SingleOrDefault();
                lbl_grade.Text = (Math.Round((double)grade,2)).ToString()+" %";
                if(Math.Round((double)grade, 2) < 60)
                {
                    lbl_grade.ForeColor = Color.Red;
                }
                else
                {
                    lbl_grade.ForeColor = Color.Green;
                    lbl_cong.Visible = true;
                }
            }
        }
    }
}
