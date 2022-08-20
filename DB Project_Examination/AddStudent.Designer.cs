namespace DB_Project_Examination
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.eeror_fname = new System.Windows.Forms.Label();
            this.Errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.Valid_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(445, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(311, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(312, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(335, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(317, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(309, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dept Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(354, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Age";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.Gray;
            this.txt_fname.Location = new System.Drawing.Point(425, 138);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(252, 29);
            this.txt_fname.TabIndex = 9;
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.Color.Gray;
            this.txt_lname.Location = new System.Drawing.Point(425, 178);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(252, 29);
            this.txt_lname.TabIndex = 10;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Gray;
            this.txt_pass.Location = new System.Drawing.Point(425, 263);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(252, 29);
            this.txt_pass.TabIndex = 11;
            // 
            // combo_gender
            // 
            this.combo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gender.ForeColor = System.Drawing.Color.Gray;
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Location = new System.Drawing.Point(425, 221);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(252, 32);
            this.combo_gender.TabIndex = 12;
            // 
            // combo_dept
            // 
            this.combo_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dept.ForeColor = System.Drawing.Color.Gray;
            this.combo_dept.FormattingEnabled = true;
            this.combo_dept.Location = new System.Drawing.Point(425, 311);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(252, 32);
            this.combo_dept.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Gray;
            this.numericUpDown1.Location = new System.Drawing.Point(425, 365);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(252, 29);
            this.numericUpDown1.TabIndex = 16;
            // 
            // eeror_fname
            // 
            this.eeror_fname.AutoSize = true;
            this.eeror_fname.Cursor = System.Windows.Forms.Cursors.Default;
            this.eeror_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eeror_fname.ForeColor = System.Drawing.Color.Red;
            this.eeror_fname.Location = new System.Drawing.Point(683, 142);
            this.eeror_fname.Name = "eeror_fname";
            this.eeror_fname.Size = new System.Drawing.Size(0, 20);
            this.eeror_fname.TabIndex = 19;
            // 
            // Errors
            // 
            this.Errors.ContainerControl = this;
            // 
            // Valid_error
            // 
            this.Valid_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Valid_error.AutoSize = true;
            this.Valid_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Valid_error.Location = new System.Drawing.Point(698, 419);
            this.Valid_error.Name = "Valid_error";
            this.Valid_error.Size = new System.Drawing.Size(0, 18);
            this.Valid_error.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project_Examination.Properties.Resources._117_1177134_benq_interactive_display_hd_png_download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 279);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancl
            // 
            this.btn_cancl.BackColor = System.Drawing.Color.White;
            this.btn_cancl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancl.ForeColor = System.Drawing.Color.Black;
            this.btn_cancl.Image = global::DB_Project_Examination.Properties.Resources.trash;
            this.btn_cancl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancl.Location = new System.Drawing.Point(594, 410);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(83, 37);
            this.btn_cancl.TabIndex = 17;
            this.btn_cancl.Text = "     Clear";
            this.btn_cancl.UseVisualStyleBackColor = false;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Image = global::DB_Project_Examination.Properties.Resources.add_user__2_1;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(425, 410);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 37);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "       Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valid_error);
            this.Controls.Add(this.eeror_fname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.combo_dept);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.ComboBox combo_dept;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eeror_fname;
        private System.Windows.Forms.ErrorProvider Errors;
        private System.Windows.Forms.Label Valid_error;
    }
}