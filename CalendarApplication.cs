using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendar
{
    static class CalendarApplication
    {
        internal static MainForm MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();

            Application.Run(MainForm);


        }
    }
}