using System;
using System.Collections.Generic;

namespace UniqueInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueInOrder("AABBCDDBB");
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            char[] chars = iterable.ToString().ToCharArray();
            List<string> finalString = new List<string>();

            for(int i = 0; i < chars.Length; i++)
            {
                if(!CheckEqualNextCharacters(chars[i] , chars[i+1]) && !finalString.Contains(chars[i].ToString()))
                    finalString.Add(chars[i].ToString());
            }
            return finalString.GetEnumerator();
        }
        public static bool CheckEqualNextCharacters(char ch , char nextCh)
        {
            if (ch.Equals(nextCh))
                return true;

            return false;
        }
    }
}
