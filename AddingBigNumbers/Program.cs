using System.Numerics;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string solu = Add("999999999", "1");
        }
        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}