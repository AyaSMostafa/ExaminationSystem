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
    public partial class Control_Instructor : Form
    {
        public Control_Instructor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((this.ParentForm) as Welcome_Form).formload(new Instructor());
        }
    }
}
