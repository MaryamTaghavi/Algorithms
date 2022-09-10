using System;
using System.Collections.Generic;
using System.Linq;

namespace YourOrder_Please
{
    class Program
    {
        static void Main(string[] args)
        {
            var result =Order("is2 Thi1s T4est 3a");
        }
        public static string Order(string words)
        {
            //Solution1
            string result = "";
            if (String.IsNullOrEmpty(words))
                return result;
            string[] str;
            str = words.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                    if (str[j].Contains((i + 1).ToString()))
                    {
                        if (i == str.Length - 1)
                        {
                            result += str[j].ToString();
                            break;
                        }

                        result += str[j].ToString() + " ";
                        break;
                    }
            }

            return result;

            //Solution2
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
}
