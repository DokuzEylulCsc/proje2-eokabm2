using System;
using System.Windows.Forms;

namespace Project2_OOP
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
            Application.Run(HotelReservationApp.GetInstance());
        }
    }
}
