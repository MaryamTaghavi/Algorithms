using System.Collections.Generic;

namespace CodeWare_SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            string[] solu = Solution(str);
        }
        public static string[] Solution(string str)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i = i + 2)
            {
                if (i == str.Length - 1 || i == str.Length - 2)
                {
                    if (str.Length % 2 != 0)
                    {
                        list.Add(str.Substring(i) + "_");
                        continue;
                    }
                    else
                    {
                        list.Add(str.Substring(i));
                        continue;
                    }
                }
                list.Add(str.Substring(i, 2));
            }
            return list.ToArray();
        }

    }
}