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
        public DateTime Date { get => date; set => date = value; } //set?

        private AppDate() { }
        private static AppDate appDate = new AppDate();

        internal static AppDate GetInstance() { return appDate; }

        internal void NextDay()
        {
            Date.AddDays(1);
        }

        public bool AreBetween(DateTime date1, DateTime date2)
        {
            if(date1 <= this.Date && this.Date < date2)
            { return true; }
            return false;
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", Date.Day, Date.Month, Date.Year);
        }

    }
}
