using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrayWeek.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TrayWeekApplicationContext applicationContext = new TrayWeekApplicationContext();
            Application.Run(applicationContext);
        }
    }
}
