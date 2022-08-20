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
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }
        
        public  void formload(Form form)
        {
            this.mainpanel.Controls.Clear();
            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formload(new Login(true));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formload(new Login(false));
        }
    }

}
