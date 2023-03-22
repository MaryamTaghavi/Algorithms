using System.Numerics;
using System.Text.RegularExpressions;

namespace BinaryMultipleOf3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryRegex.MultipleOf3().IsMatch(" 0");
            var result1 = BinaryRegex.MultipleOf3().IsMatch("000");
            var result2 = BinaryRegex.MultipleOf3().IsMatch("1001");
            var result3 = BinaryRegex.MultipleOf3().IsMatch(Convert.ToString(12345678, 2));

        }
        public class BinaryRegex
        {
            public static Regex MultipleOf3()
            {
               // int output = Convert.ToInt32(input, 2);

                // Regular expression that matches binary inputs that are multiple of 3
                return new Regex("/^(0|1(01*0)*1)*$/");
            }
        }
    }
}