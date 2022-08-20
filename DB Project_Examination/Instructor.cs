using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
           
        }
       public void formload( Form form)
        {
            this.panelshow.Controls.Clear();
            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelshow.Controls.Add(f);
            this.panelshow.Tag = f;
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            formload(new AddStudent());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formload(new  course());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formload(new Generate_exam());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formload(new  AddQuestion_Form());
        }

        private void button5_Click(object sender, EventArgs e)
        {
           formload(new Reports());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formload(new Stud_Register_Crs_Form());
        }
    }
}
