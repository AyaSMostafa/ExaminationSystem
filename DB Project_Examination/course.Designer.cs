namespace DB_Project_Examination
{
    partial class course
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
            this.crs_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_insname = new System.Windows.Forms.ComboBox();
            this.errors = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_crs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crs_txt
            // 
            this.crs_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crs_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs_txt.Location = new System.Drawing.Point(539, 284);
            this.crs_txt.Name = "crs_txt";
            this.crs_txt.Size = new System.Drawing.Size(237, 29);
            this.crs_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(417, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(407, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Instructor Name";
            // 
            // cb_insname
            // 
            this.cb_insname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_insname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_insname.FormattingEnabled = true;
            this.cb_insname.Location = new System.Drawing.Point(539, 205);
            this.cb_insname.Name = "cb_insname";
            this.cb_insname.Size = new System.Drawing.Size(237, 32);
            this.cb_insname.TabIndex = 5;
            // 
            // errors
            // 
            this.errors.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project_Examination.Properties.Resources._81_814925_after_the_completion_of_a_chapter_or_syllabus2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 281);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Image = global::DB_Project_Examination.Properties.Resources.list1;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(571, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "    Course Details";
            // 
            // btn_add_crs
            // 
            this.btn_add_crs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_crs.BackColor = System.Drawing.Color.White;
            this.btn_add_crs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_crs.Image = global::DB_Project_Examination.Properties.Resources.add_file1;
            this.btn_add_crs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_crs.Location = new System.Drawing.Point(539, 345);
            this.btn_add_crs.Name = "btn_add_crs";
            this.btn_add_crs.Size = new System.Drawing.Size(99, 29);
            this.btn_add_crs.TabIndex = 4;
            this.btn_add_crs.Text = "        Add ";
            this.btn_add_crs.UseVisualStyleBackColor = false;
            this.btn_add_crs.Click += new System.EventHandler(this.btn_add_crs_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_insname);
            this.Controls.Add(this.btn_add_crs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crs_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "course";
            this.Load += new System.EventHandler(this.course_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox crs_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_crs;
        private System.Windows.Forms.ComboBox cb_insname;
        private System.Windows.Forms.ErrorProvider errors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}