using System.Security.Cryptography;

namespace FindTheOddInt
{
    //Descriptions:
    //Given an array of integers, find the one that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.

    class Program
    {
        static void Main(string[] args)
        {

            int solu = find_it(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 });
        }
        static int find_it(int[] seq)
        {
            //Best Solution
            // return seq.OrderBy(x => x == 0).ToArray();

            //My Solution
            return seq.GroupBy(x => x)
           .Select(x => new
           {
               Count = x.Count(),
               Num = x.Key
           }).SingleOrDefault(r => r.Count % 2 != 0)?.Num ?? 0;
        }
    }
}