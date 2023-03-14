
namespace PyramidSlideDown
{
    public class Program
    {
        static void Main(string[] args)
        {
            var smallPyramid = new[]
         {
                new[] {3},
              new[] {7, 4},
              new[] {2, 4, 6},
              new[] {8, 5, 9, 3}
          };
            int solu = LongestSlideDown(smallPyramid);
        }
        public static int LongestSlideDown(int[][] pyramid)
        {
            var sum = 0;
            try
            {
                sum = pyramid[0].Max();
                var index = pyramid[0].ToList().IndexOf(pyramid[0].Max());

                for (int i = 1; i < pyramid.Length; i++)
                {
                    sum += Math.Max(pyramid[i][index], pyramid[i][index + 1]);
                    index = pyramid[i][index] > pyramid[i][index + 1] ? index : index + 1;
                }
            }
            catch(Exception ex)
            {

            }
            return sum;
        }
    }
}