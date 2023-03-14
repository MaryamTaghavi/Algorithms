using System.Security.Cryptography;
using System.Linq;

namespace FindTheOddInt
{
    //Descriptions:
    //Given an array of integers, find the one that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.

    class Program
    {
        static void Main(string[] args)
        {

            int solu = find_it(new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
        }
        static int find_it(int[] seq)
        {
            //Best Solution
            //return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;


            //My Solution
            return seq.ToList().GroupBy(x => x)
           .Select(x => new
           {
               Count = x.Count(),
               Num = x.Key
           }).SingleOrDefault(r => r.Count % 2 != 0)?.Num ?? 0;
        }
    }
}