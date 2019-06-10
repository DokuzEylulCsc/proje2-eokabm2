using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_OOP
{
    class AppDate
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private AppDate() { }
        private static AppDate appDate = new AppDate();

        internal static AppDate GetInstance() { return appDate; }

        internal void NextDay()
        {
            date = date.AddDays(1);
        }

        public bool AreBetween(DateTime date1, DateTime date2)
        {
            if(date1 <= this.Date && this.Date < date2)
            { return true; }
            return false;
        }

        public override string ToString()
        {
            return Date.Day.ToString("00") + "/" + Date.Month.ToString("00") + "/" + Date.Year.ToString("00");
        }

    }
}
