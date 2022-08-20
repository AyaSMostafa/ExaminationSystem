namespace DB_Project_Examination
{
    partial class AddQuestion_Form
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
            this.components = new System.ComponentModel.Container();
            this.cb_courselist = new System.Windows.Forms.ComboBox();
            this.lbl_courses = new System.Windows.Forms.Label();
            this.panel_Question = new System.Windows.Forms.Panel();
            this.qHeader = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_rAns = new System.Windows.Forms.ComboBox();
            this.lbl_rAns = new System.Windows.Forms.Label();
            this.btn_addChoice = new System.Windows.Forms.Button();
            this.rtxt_Choice = new System.Windows.Forms.RichTextBox();
            this.lbl_Choice = new System.Windows.Forms.Label();
            this.lbl_marks = new System.Windows.Forms.Label();
            this.num_qGrade = new System.Windows.Forms.NumericUpDown();
            this.lbl_qGrade = new System.Windows.Forms.Label();
            this.lbl_qBody = new System.Windows.Forms.Label();
            this.lbl_qHeader = new System.Windows.Forms.Label();
            this.rtxt_qBody = new System.Windows.Forms.RichTextBox();
            this.lbl_qType = new System.Windows.Forms.Label();
            this.cb_qType = new System.Windows.Forms.ComboBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_courselist
            // 
            this.cb_courselist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_courselist.FormattingEnabled = true;
            this.cb_courselist.Location = new System.Drawing.Point(336, 11);
            this.cb_courselist.Margin = new System.Windows.Forms.Padding(2);
            this.cb_courselist.Name = "cb_courselist";
            this.cb_courselist.Size = new System.Drawing.Size(274, 21);
            this.cb_courselist.TabIndex = 1;
            this.cb_courselist.SelectionChangeCommitted += new System.EventHandler(this.cb_courselist_SelectionChangeCommitted);
            // 
            // lbl_courses
            // 
            this.lbl_courses.AutoSize = true;
            this.lbl_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courses.Location = new System.Drawing.Point(165, 16);
            this.lbl_courses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_courses.Name = "lbl_courses";
            this.lbl_courses.Size = new System.Drawing.Size(122, 16);
            this.lbl_courses.TabIndex = 2;
            this.lbl_courses.Text = "Choose the course:";
            // 
            // panel_Question
            // 
            this.panel_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Question.AutoScroll = true;
            this.panel_Question.Controls.Add(this.qHeader);
            this.panel_Question.Controls.Add(this.btn_submit);
            this.panel_Question.Controls.Add(this.cb_rAns);
            this.panel_Question.Controls.Add(this.lbl_rAns);
            this.panel_Question.Controls.Add(this.btn_addChoice);
            this.panel_Question.Controls.Add(this.rtxt_Choice);
            this.panel_Question.Controls.Add(this.lbl_Choice);
            this.panel_Question.Controls.Add(this.lbl_marks);
            this.panel_Question.Controls.Add(this.num_qGrade);
            this.panel_Question.Controls.Add(this.lbl_qGrade);
            this.panel_Question.Controls.Add(this.lbl_qBody);
            this.panel_Question.Controls.Add(this.lbl_qHeader);
            this.panel_Question.Controls.Add(this.rtxt_qBody);
            this.panel_Question.Location = new System.Drawing.Point(115, 74);
            this.panel_Question.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Question.Name = "panel_Question";
            this.panel_Question.Size = new System.Drawing.Size(582, 402);
            this.panel_Question.TabIndex = 3;
            // 
            // qHeader
            // 
            this.qHeader.AutoSize = true;
            this.qHeader.Location = new System.Drawing.Point(218, 57);
            this.qHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qHeader.Name = "qHeader";
            this.qHeader.Size = new System.Drawing.Size(0, 13);
            this.qHeader.TabIndex = 13;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.White;
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_submit.Image = global::DB_Project_Examination.Properties.Resources.check_mark;
            this.btn_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Location = new System.Drawing.Point(393, 349);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(101, 34);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit\r\n   Question";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_rAns
            // 
            this.cb_rAns.FormattingEnabled = true;
            this.cb_rAns.Location = new System.Drawing.Point(221, 308);
            this.cb_rAns.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rAns.Name = "cb_rAns";
            this.cb_rAns.Size = new System.Drawing.Size(274, 21);
            this.cb_rAns.TabIndex = 11;
            this.cb_rAns.SelectionChangeCommitted += new System.EventHandler(this.cb_rAns_SelectionChangeCommitted);
            // 
            // lbl_rAns
            // 
            this.lbl_rAns.AutoSize = true;
            this.lbl_rAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rAns.Location = new System.Drawing.Point(41, 309);
            this.lbl_rAns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_rAns.Name = "lbl_rAns";
            this.lbl_rAns.Size = new System.Drawing.Size(152, 16);
            this.lbl_rAns.TabIndex = 10;
            this.lbl_rAns.Text = "Choose the right answer:";
            // 
            // btn_addChoice
            // 
            this.btn_addChoice.BackColor = System.Drawing.Color.White;
            this.btn_addChoice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addChoice.Image = global::DB_Project_Examination.Properties.Resources.add_file;
            this.btn_addChoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addChoice.Location = new System.Drawing.Point(393, 252);
            this.btn_addChoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addChoice.Name = "btn_addChoice";
            this.btn_addChoice.Size = new System.Drawing.Size(101, 35);
            this.btn_addChoice.TabIndex = 9;
            this.btn_addChoice.Text = "  Insert   \r\n  Choice";
            this.btn_addChoice.UseVisualStyleBackColor = false;
            this.btn_addChoice.Click += new System.EventHandler(this.btn_addChoice_Click);
            // 
            // rtxt_Choice
            // 
            this.rtxt_Choice.Location = new System.Drawing.Point(221, 176);
            this.rtxt_Choice.Margin = new System.Windows.Forms.Padding(2);
            this.rtxt_Choice.Name = "rtxt_Choice";
            this.rtxt_Choice.Size = new System.Drawing.Size(274, 62);
            this.rtxt_Choice.TabIndex = 8;
            this.rtxt_Choice.Text = "";
            this.rtxt_Choice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtxt_Choice_MouseDown);
            // 
            // lbl_Choice
            // 
            this.lbl_Choice.AutoSize = true;
            this.lbl_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Choice.Location = new System.Drawing.Point(41, 187);
            this.lbl_Choice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Choice.Name = "lbl_Choice";
            this.lbl_Choice.Size = new System.Drawing.Size(77, 16);
            this.lbl_Choice.TabIndex = 7;
            this.lbl_Choice.Text = "Add Choice";
            // 
            // lbl_marks
            // 
            this.lbl_marks.AutoSize = true;
            this.lbl_marks.Location = new System.Drawing.Point(297, 18);
            this.lbl_marks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_marks.Name = "lbl_marks";
            this.lbl_marks.Size = new System.Drawing.Size(35, 13);
            this.lbl_marks.TabIndex = 6;
            this.lbl_marks.Text = "Marks";
            // 
            // num_qGrade
            // 
            this.num_qGrade.Location = new System.Drawing.Point(221, 16);
            this.num_qGrade.Margin = new System.Windows.Forms.Padding(2);
            this.num_qGrade.Name = "num_qGrade";
            this.num_qGrade.Size = new System.Drawing.Size(62, 20);
            this.num_qGrade.TabIndex = 5;
            this.num_qGrade.ValueChanged += new System.EventHandler(this.num_qGrade_ValueChanged);
            // 
            // lbl_qGrade
            // 
            this.lbl_qGrade.AutoSize = true;
            this.lbl_qGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qGrade.Location = new System.Drawing.Point(41, 18);
            this.lbl_qGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qGrade.Name = "lbl_qGrade";
            this.lbl_qGrade.Size = new System.Drawing.Size(104, 16);
            this.lbl_qGrade.TabIndex = 4;
            this.lbl_qGrade.Text = "Question Grade:";
            // 
            // lbl_qBody
            // 
            this.lbl_qBody.AutoSize = true;
            this.lbl_qBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qBody.Location = new System.Drawing.Point(41, 104);
            this.lbl_qBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qBody.Name = "lbl_qBody";
            this.lbl_qBody.Size = new System.Drawing.Size(98, 16);
            this.lbl_qBody.TabIndex = 3;
            this.lbl_qBody.Text = "Question Body:";
            // 
            // lbl_qHeader
            // 
            this.lbl_qHeader.AutoSize = true;
            this.lbl_qHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qHeader.Location = new System.Drawing.Point(41, 54);
            this.lbl_qHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qHeader.Name = "lbl_qHeader";
            this.lbl_qHeader.Size = new System.Drawing.Size(112, 16);
            this.lbl_qHeader.TabIndex = 2;
            this.lbl_qHeader.Text = "Question Header:";
            // 
            // rtxt_qBody
            // 
            this.rtxt_qBody.Location = new System.Drawing.Point(221, 93);
            this.rtxt_qBody.Margin = new System.Windows.Forms.Padding(2);
            this.rtxt_qBody.Name = "rtxt_qBody";
            this.rtxt_qBody.Size = new System.Drawing.Size(274, 79);
            this.rtxt_qBody.TabIndex = 1;
            this.rtxt_qBody.Text = "";
            this.rtxt_qBody.TextChanged += new System.EventHandler(this.rtxt_qBody_TextChanged);
            // 
            // lbl_qType
            // 
            this.lbl_qType.AutoSize = true;
            this.lbl_qType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qType.Location = new System.Drawing.Point(165, 47);
            this.lbl_qType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qType.Name = "lbl_qType";
            this.lbl_qType.Size = new System.Drawing.Size(169, 16);
            this.lbl_qType.TabIndex = 4;
            this.lbl_qType.Text = "Choose the Question Type:";
            // 
            // cb_qType
            // 
            this.cb_qType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_qType.FormattingEnabled = true;
            this.cb_qType.Location = new System.Drawing.Point(336, 41);
            this.cb_qType.Margin = new System.Windows.Forms.Padding(2);
            this.cb_qType.Name = "cb_qType";
            this.cb_qType.Size = new System.Drawing.Size(274, 21);
            this.cb_qType.TabIndex = 5;
            this.cb_qType.SelectionChangeCommitted += new System.EventHandler(this.cb_qType_SelectionChangeCommitted);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // AddQuestion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.cb_qType);
            this.Controls.Add(this.lbl_qType);
            this.Controls.Add(this.panel_Question);
            this.Controls.Add(this.lbl_courses);
            this.Controls.Add(this.cb_courselist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuestion_Form";
            this.Text = "AddQuestion_Form";
            this.Load += new System.EventHandler(this.AddQuestion_Form_Load);
            this.panel_Question.ResumeLayout(false);
            this.panel_Question.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_qGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_courselist;
        private System.Windows.Forms.Label lbl_courses;
        private System.Windows.Forms.Panel panel_Question;
        private System.Windows.Forms.RichTextBox rtxt_qBody;
        private System.Windows.Forms.Label lbl_qBody;
        private System.Windows.Forms.Label lbl_qHeader;
        private System.Windows.Forms.Label lbl_qType;
        private System.Windows.Forms.ComboBox cb_qType;
        private System.Windows.Forms.Label lbl_marks;
        private System.Windows.Forms.NumericUpDown num_qGrade;
        private System.Windows.Forms.Label lbl_qGrade;
        private System.Windows.Forms.RichTextBox rtxt_Choice;
        private System.Windows.Forms.Label lbl_Choice;
        private System.Windows.Forms.ComboBox cb_rAns;
        private System.Windows.Forms.Label lbl_rAns;
        private System.Windows.Forms.Button btn_addChoice;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label qHeader;
    }
}