using System.Collections.Generic;

namespace CodeWare_SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = TimeFormat.GetReadableTime(359999);
        }
        public static class TimeFormat
        {
            public static string GetReadableTime(int seconds)
            {
                TimeSpan t = TimeSpan.FromSeconds(seconds);

                string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                        t.Hours,
                        t.Minutes,
                        t.Seconds);

                return answer;
            }
        }
    }
}