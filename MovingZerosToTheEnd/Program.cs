namespace MovingZerosToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] solu = MoveZeroes(new int[] { 1,0, 2, 1,0, 1, 3,0, 1});
            Console.WriteLine("Helllllo");
        }
        static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderByDescending(x => x == 0).ToArray();

            // return arr.Where(e => e != 0).Concat(arr.Where(e => e == 0)).ToArray();
        }

    }
}