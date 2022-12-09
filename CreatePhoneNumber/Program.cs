namespace CreatePhoneNumber
{
    //Description
    //Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

    class Program
    {
        static void Main(string[] args)
        {
            var str = CreatePhoneNumber2(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 });
            Console.WriteLine(str);
        }
        //Solution1

        public static string CreatePhoneNumber1(int[] numbers)
        {
            string str = "";
            str += "(" + numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString()
              + ")" + " " + numbers[3].ToString() + numbers[4].ToString() + numbers[5].ToString() + "-"
              + numbers[6].ToString() + numbers[7].ToString() + numbers[8].ToString() + numbers[9].ToString();
            return str;
        }


        //Solution2

        public static string CreatePhoneNumber2(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }

    }
}