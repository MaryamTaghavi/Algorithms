using System.Drawing;

namespace RGBToHexConversion
{
    public class Program
    {
        static void Main(string[] args)
        {         
            string solu = Rgb(148, -20, 211);
            string solu1 = Rgb(212, 53, 12);
            string solu2 = Rgb(269, 209, 201);
        }
        public static string Rgb(int r, int g, int b)
        {
            r = Math.Min(255, r);
            g = Math.Min(255, g);
            b = Math.Min(255, b);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);

        }
    }
}