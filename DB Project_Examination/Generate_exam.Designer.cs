namespace DB_Project_Examination
{
    partial class Generate_exam
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
            this.lbl_mcq = new System.Windows.Forms.Label();
            this.lbl_tf = new System.Windows.Forms.Label();
            this.N_MCQ = new System.Windows.Forms.NumericUpDown();
            this.N_TF = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_crs_id = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_duo_ex = new System.Windows.Forms.Label();
            this.duration_Ex = new System.Windows.Forms.NumericUpDown();
            this.date_exam = new System.Windows.Forms.DateTimePicker();
            this.date_ex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_assign_Ex = new System.Windows.Forms.Button();
            this.btn_generate_ex = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.N_MCQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_TF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_Ex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mcq
            // 
            this.lbl_mcq.AutoSize = true;
            this.lbl_mcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mcq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_mcq.Location = new System.Drawing.Point(372, 228);
            this.lbl_mcq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mcq.Name = "lbl_mcq";
            this.lbl_mcq.Size = new System.Drawing.Size(116, 18);
            this.lbl_mcq.TabIndex = 18;
            this.lbl_mcq.Text = "MCQ Questions";
            // 
            // lbl_tf
            // 
            this.lbl_tf.AutoSize = true;
            this.lbl_tf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tf.Location = new System.Drawing.Point(372, 184);
            this.lbl_tf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tf.Name = "lbl_tf";
            this.lbl_tf.Size = new System.Drawing.Size(178, 18);
            this.lbl_tf.TabIndex = 17;
            this.lbl_tf.Text = "True and False Questions";
            // 
            // N_MCQ
            // 
            this.N_MCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_MCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.N_MCQ.Location = new System.Drawing.Point(492, 225);
            this.N_MCQ.Margin = new System.Windows.Forms.Padding(2);
            this.N_MCQ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.N_MCQ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_MCQ.Name = "N_MCQ";
            this.N_MCQ.Size = new System.Drawing.Size(199, 26);
            this.N_MCQ.TabIndex = 16;
            this.N_MCQ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_MCQ.ValueChanged += new System.EventHandler(this.N_MCQ_ValueChanged);
            // 
            // N_TF
            // 
            this.N_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_TF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.N_TF.Location = new System.Drawing.Point(554, 181);
            this.N_TF.Margin = new System.Windows.Forms.Padding(2);
            this.N_TF.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.N_TF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_TF.Name = "N_TF";
            this.N_TF.Size = new System.Drawing.Size(137, 26);
            this.N_TF.TabIndex = 15;
            this.N_TF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_TF.ValueChanged += new System.EventHandler(this.N_TF_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(372, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Course Name";
            // 
            // cb_crs_id
            // 
            this.cb_crs_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_crs_id.FormattingEnabled = true;
            this.cb_crs_id.Location = new System.Drawing.Point(489, 139);
            this.cb_crs_id.Margin = new System.Windows.Forms.Padding(2);
            this.cb_crs_id.Name = "cb_crs_id";
            this.cb_crs_id.Size = new System.Drawing.Size(202, 28);
            this.cb_crs_id.TabIndex = 11;
            this.cb_crs_id.SelectionChangeCommitted += new System.EventHandler(this.start_generate);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_duo_ex
            // 
            this.lbl_duo_ex.AutoSize = true;
            this.lbl_duo_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duo_ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_duo_ex.Location = new System.Drawing.Point(372, 273);
            this.lbl_duo_ex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_duo_ex.Name = "lbl_duo_ex";
            this.lbl_duo_ex.Size = new System.Drawing.Size(103, 18);
            this.lbl_duo_ex.TabIndex = 22;
            this.lbl_duo_ex.Text = "Exam duration";
            // 
            // duration_Ex
            // 
            this.duration_Ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_Ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.duration_Ex.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.duration_Ex.Location = new System.Drawing.Point(489, 270);
            this.duration_Ex.Margin = new System.Windows.Forms.Padding(2);
            this.duration_Ex.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.duration_Ex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration_Ex.Name = "duration_Ex";
            this.duration_Ex.Size = new System.Drawing.Size(202, 26);
            this.duration_Ex.TabIndex = 24;
            this.duration_Ex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration_Ex.ValueChanged += new System.EventHandler(this.duration_Ex_ValueChanged);
            // 
            // date_exam
            // 
            this.date_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_exam.Location = new System.Drawing.Point(489, 314);
            this.date_exam.Margin = new System.Windows.Forms.Padding(2);
            this.date_exam.Name = "date_exam";
            this.date_exam.Size = new System.Drawing.Size(202, 26);
            this.date_exam.TabIndex = 25;
            this.date_exam.ValueChanged += new System.EventHandler(this.date_exam_ValueChanged);
            // 
            // date_ex
            // 
            this.date_ex.AutoSize = true;
            this.date_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date_ex.Location = new System.Drawing.Point(372, 320);
            this.date_ex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_ex.Name = "date_ex";
            this.date_ex.Size = new System.Drawing.Size(39, 18);
            this.date_ex.TabIndex = 26;
            this.date_ex.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Generate Exam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Image = global::DB_Project_Examination.Properties.Resources.list;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(532, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "   Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DB_Project_Examination.Properties.Resources._242_2423250_exam_png_transparent_image_exam_png_png_download;
            this.pictureBox1.Location = new System.Drawing.Point(33, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btn_assign_Ex
            // 
            this.btn_assign_Ex.BackColor = System.Drawing.Color.White;
            this.btn_assign_Ex.Image = global::DB_Project_Examination.Properties.Resources.bell;
            this.btn_assign_Ex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_assign_Ex.Location = new System.Drawing.Point(606, 379);
            this.btn_assign_Ex.Margin = new System.Windows.Forms.Padding(2);
            this.btn_assign_Ex.Name = "btn_assign_Ex";
            this.btn_assign_Ex.Size = new System.Drawing.Size(85, 31);
            this.btn_assign_Ex.TabIndex = 20;
            this.btn_assign_Ex.Text = "     Notify";
            this.btn_assign_Ex.UseVisualStyleBackColor = false;
            this.btn_assign_Ex.Click += new System.EventHandler(this.btn_assign_Ex_Click);
            // 
            // btn_generate_ex
            // 
            this.btn_generate_ex.BackColor = System.Drawing.Color.White;
            this.btn_generate_ex.Image = global::DB_Project_Examination.Properties.Resources.exam__1_;
            this.btn_generate_ex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generate_ex.Location = new System.Drawing.Point(489, 379);
            this.btn_generate_ex.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generate_ex.Name = "btn_generate_ex";
            this.btn_generate_ex.Size = new System.Drawing.Size(85, 31);
            this.btn_generate_ex.TabIndex = 19;
            this.btn_generate_ex.Text = "       Generate";
            this.btn_generate_ex.UseVisualStyleBackColor = false;
            this.btn_generate_ex.Click += new System.EventHandler(this.btn_generate_ex_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(492, 356);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 30;
            // 
            // Generate_exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(757, 474);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.duration_Ex);
            this.Controls.Add(this.date_exam);
            this.Controls.Add(this.date_ex);
            this.Controls.Add(this.lbl_duo_ex);
            this.Controls.Add(this.btn_assign_Ex);
            this.Controls.Add(this.btn_generate_ex);
            this.Controls.Add(this.lbl_mcq);
            this.Controls.Add(this.lbl_tf);
            this.Controls.Add(this.N_MCQ);
            this.Controls.Add(this.N_TF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_crs_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Generate_exam";
            this.Text = "Generate_exam";
            this.Load += new System.EventHandler(this.Generate_exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N_MCQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_TF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_Ex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_assign_Ex;
        private System.Windows.Forms.Button btn_generate_ex;
        private System.Windows.Forms.Label lbl_mcq;
        private System.Windows.Forms.Label lbl_tf;
        private System.Windows.Forms.NumericUpDown N_MCQ;
        private System.Windows.Forms.NumericUpDown N_TF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_crs_id;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown duration_Ex;
        private System.Windows.Forms.DateTimePicker date_exam;
        private System.Windows.Forms.Label date_ex;
        private System.Windows.Forms.Label lbl_duo_ex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_error;
    }
}