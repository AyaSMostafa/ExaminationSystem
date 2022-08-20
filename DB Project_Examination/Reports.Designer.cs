namespace DB_Project_Examination
{
    partial class Reports
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
            this.cb_selectReport = new System.Windows.Forms.ComboBox();
            this.rv_displayReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_selectReport
            // 
            this.cb_selectReport.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_selectReport.FormattingEnabled = true;
            this.cb_selectReport.Location = new System.Drawing.Point(272, 22);
            this.cb_selectReport.Name = "cb_selectReport";
            this.cb_selectReport.Size = new System.Drawing.Size(438, 31);
            this.cb_selectReport.TabIndex = 0;
            this.cb_selectReport.SelectedIndexChanged += new System.EventHandler(this.cb_selectReport_SelectedIndexChanged);
            // 
            // rv_displayReport
            // 
            this.rv_displayReport.Location = new System.Drawing.Point(12, 70);
            this.rv_displayReport.Name = "rv_displayReport";
            this.rv_displayReport.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rv_displayReport.ServerReport.BearerToken = null;
            this.rv_displayReport.Size = new System.Drawing.Size(776, 368);
            this.rv_displayReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Report:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv_displayReport);
            this.Controls.Add(this.cb_selectReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_selectReport;
        private Microsoft.Reporting.WinForms.ReportViewer rv_displayReport;
        private System.Windows.Forms.Label label1;
    }
}