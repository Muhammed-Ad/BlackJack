using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //aShoe dealingShoe = new aShoe();
            //dealingShoe.Draw

           /* 
            var main_form = new Form1();
            main_form.Show();
            Application.Run();
           */
        }
    }
}
