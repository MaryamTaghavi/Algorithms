using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CodeWare_SplitStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string solu = Solution(1358);
        }
        public static string Solution(int n)
        {
            //Solution1
            string romanResult = string.Empty;
            string[] romanLetters = {
        "M",
        "CM",
        "D",
        "CD",
        "C",
        "XC",
        "L",
        "XL",
        "X",
        "IX",
        "V",
        "IV",
        "I"
    };
            int[] numbers = {
        1000,
        900,
        500,
        400,
        100,
        90,
        50,
        40,
        10,
        9,
        5,
        4,
        1
    };
            int i = 0;
            while (n != 0)
            {
                if (n >= numbers[i])
                {
                    n -= numbers[i];
                    romanResult += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            return romanResult;

            //Solution2

            string roman = "";
            string[] thousand = { "", "M", "MM", "MMM" };
            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            roman += thousand[(n / 1000) % 10];
            roman += hundred[(n / 100) % 10];
            roman += ten[(n / 10) % 10];
            roman += one[n % 10];

            return roman;
        }

    }

    #region Description

    /*Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

    Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero.In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

    Example:

    RomanConvert.Solution(1000) -- should return "M"
    Help:

    Symbol    Value
    I          1
    V          5
    X          10
    L          50
    C          100
    D          500
    M          1,000
    Remember that there can't be more than 3 identical symbols in a row.
    */

    #endregion
}