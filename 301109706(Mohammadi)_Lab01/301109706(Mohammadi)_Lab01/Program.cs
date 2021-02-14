using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301109706_Mohammadi__Lab01
{
    static class Program
    {
        //Declare an instance variable of publisher class. 
        public static Publisher publisher = new Publisher();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartingForm());
        }
    }
}
