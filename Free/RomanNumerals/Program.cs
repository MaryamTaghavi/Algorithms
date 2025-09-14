using System;

namespace RomanNumerals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = FromRoman("II");
            var chars = ToRoman(2);
        }
        public static string ToRoman(int n)
        {
            string romanResult = "";
            Dictionary<string, int> romanNumbersDictionary = new() {
            {
                "I",
                1
            }, {
                "IV",
                4
            }, {
                "V",
                5
            }, {
                "IX",
                9
            }, {
                "X",
                10
            }, {
                "XL",
                40
            }, {
                "L",
                50
            }, {
                "XC",
                90
            }, {
                "C",
                100
            }, {
                "CD",
                400
            }, {
                "D",
                500
            }, {
                "CM",
                900
            }, {
                "M",
                1000
            }
        };
            foreach (var item in romanNumbersDictionary.Reverse())
            {
                if (n <= 0) break;
                while (n >= item.Value)
                {
                    romanResult += item.Key;
                    n -= item.Value;
                }
            }
            return romanResult;
        }
        public static int FromRoman(string romanNumeral)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                char currentRomanChar = romanNumeral[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < romanNumeral.Length && romanNumbersDictionary[romanNumeral[i + 1]] > romanNumbersDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}