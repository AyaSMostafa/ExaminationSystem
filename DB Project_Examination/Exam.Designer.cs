namespace DB_Project_Examination
{
    partial class Exam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_choices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_quesHead = new System.Windows.Forms.Label();
            this.lbl_quesMark = new System.Windows.Forms.Label();
            this.flp_questionList = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.rtb_quesBody = new System.Windows.Forms.RichTextBox();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pan_wait = new System.Windows.Forms.Panel();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.lbl_waitGrade = new System.Windows.Forms.Label();
            this.lbl_cong = new System.Windows.Forms.Label();
            this.pan_wait.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_choices
            // 
            this.cb_choices.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choices.FormattingEnabled = true;
            this.cb_choices.Location = new System.Drawing.Point(70, 314);
            this.cb_choices.Name = "cb_choices";
            this.cb_choices.Size = new System.Drawing.Size(632, 31);
            this.cb_choices.TabIndex = 1;
            this.cb_choices.SelectionChangeCommitted += new System.EventHandler(this.cb_choices_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choices:";
            // 
            // lbl_quesHead
            // 
            this.lbl_quesHead.AutoSize = true;
            this.lbl_quesHead.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quesHead.Location = new System.Drawing.Point(66, 118);
            this.lbl_quesHead.Name = "lbl_quesHead";
            this.lbl_quesHead.Size = new System.Drawing.Size(103, 23);
            this.lbl_quesHead.TabIndex = 4;
            this.lbl_quesHead.Text = "Question:";
            // 
            // lbl_quesMark
            // 
            this.lbl_quesMark.AutoSize = true;
            this.lbl_quesMark.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quesMark.Location = new System.Drawing.Point(611, 118);
            this.lbl_quesMark.Name = "lbl_quesMark";
            this.lbl_quesMark.Size = new System.Drawing.Size(67, 23);
            this.lbl_quesMark.TabIndex = 6;
            this.lbl_quesMark.Text = "Marks";
            // 
            // flp_questionList
            // 
            this.flp_questionList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_questionList.Location = new System.Drawing.Point(32, 14);
            this.flp_questionList.Name = "flp_questionList";
            this.flp_questionList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp_questionList.Size = new System.Drawing.Size(724, 59);
            this.flp_questionList.TabIndex = 7;
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_prev.Location = new System.Drawing.Point(70, 374);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(100, 46);
            this.btn_prev.TabIndex = 8;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_next.Location = new System.Drawing.Point(400, 374);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 46);
            this.btn_next.TabIndex = 9;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // rtb_quesBody
            // 
            this.rtb_quesBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_quesBody.Enabled = false;
            this.rtb_quesBody.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_quesBody.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_quesBody.Location = new System.Drawing.Point(70, 159);
            this.rtb_quesBody.Name = "rtb_quesBody";
            this.rtb_quesBody.Size = new System.Drawing.Size(632, 96);
            this.rtb_quesBody.TabIndex = 10;
            this.rtb_quesBody.Text = "";
            // 
            // btn_review
            // 
            this.btn_review.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_review.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_review.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_review.Location = new System.Drawing.Point(201, 374);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(168, 46);
            this.btn_review.TabIndex = 11;
            this.btn_review.Text = "Mark For Review";
            this.btn_review.UseVisualStyleBackColor = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Crimson;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submit.Location = new System.Drawing.Point(602, 374);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(144, 46);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pan_wait
            // 
            this.pan_wait.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pan_wait.Controls.Add(this.lbl_cong);
            this.pan_wait.Controls.Add(this.lbl_grade);
            this.pan_wait.Controls.Add(this.lbl_waitGrade);
            this.pan_wait.Location = new System.Drawing.Point(12, 12);
            this.pan_wait.Name = "pan_wait";
            this.pan_wait.Size = new System.Drawing.Size(776, 426);
            this.pan_wait.TabIndex = 13;
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grade.Location = new System.Drawing.Point(287, 280);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(0, 44);
            this.lbl_grade.TabIndex = 1;
            // 
            // lbl_waitGrade
            // 
            this.lbl_waitGrade.AutoSize = true;
            this.lbl_waitGrade.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waitGrade.Location = new System.Drawing.Point(164, 187);
            this.lbl_waitGrade.Name = "lbl_waitGrade";
            this.lbl_waitGrade.Size = new System.Drawing.Size(446, 44);
            this.lbl_waitGrade.TabIndex = 0;
            this.lbl_waitGrade.Text = "Wait Loading The Exam";
            // 
            // lbl_cong
            // 
            this.lbl_cong.AutoSize = true;
            this.lbl_cong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cong.Font = new System.Drawing.Font("Apple Chancery", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cong.Location = new System.Drawing.Point(266, 106);
            this.lbl_cong.Name = "lbl_cong";
            this.lbl_cong.Size = new System.Drawing.Size(254, 46);
            this.lbl_cong.TabIndex = 4;
            this.lbl_cong.Text = "Congratulations";
            this.lbl_cong.Visible = false;
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_wait);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.flp_questionList);
            this.Controls.Add(this.lbl_quesHead);
            this.Controls.Add(this.rtb_quesBody);
            this.Controls.Add(this.lbl_quesMark);
            this.Controls.Add(this.cb_choices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_prev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam";
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.pan_wait.ResumeLayout(false);
            this.pan_wait.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_choices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_quesHead;
        private System.Windows.Forms.Label lbl_quesMark;
        private System.Windows.Forms.FlowLayoutPanel flp_questionList;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RichTextBox rtb_quesBody;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel pan_wait;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label lbl_waitGrade;
        private System.Windows.Forms.Label lbl_cong;
    }
}