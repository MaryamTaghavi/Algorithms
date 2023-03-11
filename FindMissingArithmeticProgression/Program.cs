namespace FindMissingArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {

            int solu = FindMissing(new List<int> { 1,5,7 });
        }
        static int FindMissing(List<int> list)
        {
            //My Solution
            //var d = 0;
            //for (int i = 0 ; i < list.Count  ; i++)
            //{
            //    if (d == 0)
            //    {
            //        d = list[i+1] - list[i];
            //    }
            //    else
            //    {
            //        if(list[i+1] - list[i] != d)
            //        {
            //            if (list[i + 1] - list[i] < d)
            //                return list[i - 1] + list[i + 1] - list[i];
            //            else
            //                return list[i] + d;
            //        }
            //    }
            //}

            //return d;

            //Best Solution

            int step = (list.Last() - list.First()) / list.Count();
            int current = list.First();

            // Iterate over the list and return the first value which is not present in the Progression
            for (int i = 0; i < list.Count(); ++i)
            {
                if (list[i] != current) { return current; }
                current += step;
            }

            return current;
        }
    }
}