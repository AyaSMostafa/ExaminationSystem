using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_Examination
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Welcome_Form Main_Form = new Welcome_Form();
            Application.Run(Main_Form);
            //Application.Run(new Generate_exam());
        }
    }
}
