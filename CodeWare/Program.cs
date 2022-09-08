using System;

namespace CodeWare_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot(129);
        }
        public static int DigitalRoot(long n)
        {
            string str = n + "";
            char[] digits = str.ToCharArray();

            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
                sum += (int)Char.GetNumericValue(digits[i]);

            if ((sum + "").ToCharArray().Length == 1)
                return sum;
            
            return DigitalRoot(sum);
        }
    }
}