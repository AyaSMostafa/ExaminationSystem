namespace DB_Project_Examination
{
    partial class Stud_Register_Crs_Form
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
            this.cb_crs = new System.Windows.Forms.ComboBox();
            this.lbl_crs = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_crs
            // 
            this.cb_crs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_crs.FormattingEnabled = true;
            this.cb_crs.Location = new System.Drawing.Point(484, 183);
            this.cb_crs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_crs.Name = "cb_crs";
            this.cb_crs.Size = new System.Drawing.Size(248, 28);
            this.cb_crs.TabIndex = 0;
            this.cb_crs.SelectionChangeCommitted += new System.EventHandler(this.cb_crs_SelectionChangeCommitted);
            // 
            // lbl_crs
            // 
            this.lbl_crs.AutoSize = true;
            this.lbl_crs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crs.Location = new System.Drawing.Point(303, 187);
            this.lbl_crs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_crs.Name = "lbl_crs";
            this.lbl_crs.Size = new System.Drawing.Size(142, 18);
            this.lbl_crs.TabIndex = 1;
            this.lbl_crs.Text = "Choose the Course:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(484, 233);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(248, 94);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose the students:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Image = global::DB_Project_Examination.Properties.Resources.list1;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(550, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "    Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DB_Project_Examination.Properties.Resources.istockphoto_1268691831_170667a;
            this.pictureBox1.Location = new System.Drawing.Point(12, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::DB_Project_Examination.Properties.Resources.plus__1_1;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(623, 350);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 37);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "    Add\r\n    Students";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register Student\r\n";
            // 
            // Stud_Register_Crs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lbl_crs);
            this.Controls.Add(this.cb_crs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stud_Register_Crs_Form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Stud_Register_Crs_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_crs;
        private System.Windows.Forms.Label lbl_crs;
        private System.Windows.Forms.CheckedListBox listBox;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}