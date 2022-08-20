namespace DB_Project_Examination
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_eror = new System.Windows.Forms.Label();
            this.pass_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.user_eror);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pass_error);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_cancl);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 570);
            this.panel1.TabIndex = 0;
            // 
            // user_eror
            // 
            this.user_eror.AutoSize = true;
            this.user_eror.Location = new System.Drawing.Point(644, 365);
            this.user_eror.Name = "user_eror";
            this.user_eror.Size = new System.Drawing.Size(0, 13);
            this.user_eror.TabIndex = 10;
            // 
            // pass_error
            // 
            this.pass_error.AutoSize = true;
            this.pass_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_error.ForeColor = System.Drawing.Color.Red;
            this.pass_error.Location = new System.Drawing.Point(638, 362);
            this.pass_error.Name = "pass_error";
            this.pass_error.Size = new System.Drawing.Size(0, 16);
            this.pass_error.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(543, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(532, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(710, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(643, 249);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(240, 29);
            this.txt_pass.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(643, 202);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(240, 29);
            this.txt_username.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_Project_Examination.Properties.Resources._57_573953_png_images_free_download_high_school_student_clipart;
            this.pictureBox1.Location = new System.Drawing.Point(71, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 270);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancl
            // 
            this.btn_cancl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancl.Image = global::DB_Project_Examination.Properties.Resources.trash1;
            this.btn_cancl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancl.Location = new System.Drawing.Point(798, 309);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(85, 29);
            this.btn_cancl.TabIndex = 4;
            this.btn_cancl.Text = "       Clear";
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = global::DB_Project_Examination.Properties.Resources.add_user__2_2;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(641, 309);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 29);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "       Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 571);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "HomenPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label pass_error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_eror;
    }
}