using System;
using System.IO;

namespace Project2_OOP
{
    public static class AppLogs
    {
        private static AppDate appDate = AppDate.GetInstance();
        private static StreamWriter sr = new StreamWriter(@"Logs.txt",true);

        public static StreamWriter Sr { get => sr; }

        public static void WriteLog(string messsage)
        {
            Sr.WriteLine(messsage + "\t" + appDate.ToString() + Environment.NewLine);
        }
    }
}
