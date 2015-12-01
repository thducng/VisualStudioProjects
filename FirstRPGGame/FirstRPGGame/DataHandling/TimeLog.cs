using System;
using System.IO;
using System.Linq;

namespace FirstRPGGame.DataHandling
{
    public class ServerLog
    {
        private string path = "server.log";

        private static string Now()
        {
            var dateTime = DateTime.Now;
            var month = dateTime.Month;
            var day = dateTime.Day;
            var hour = dateTime.Hour;
            var minute = dateTime.Minute;
            var second = dateTime.Second;
            string resVal = $"[{day}/{month} - {hour}.{minute}.{second}]";
            return resVal;
        }

        public void Log(string text)
        {
            string fullString = $"{Now()} : {text}";
            /*checkFileSize();
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(fullString);
            file.Close();*/
            Console.WriteLine(fullString);
        }

        private void checkFileSize()
        {
            int lines = File.ReadLines(path).Count();
            if (lines > 10000)
            {
                File.Delete(path);
            }
            
        }
         
    }
}