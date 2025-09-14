namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string solu = FirstNonRepeatingLetter("sTreSS");
        }
        public static string FirstNonRepeatingLetter(string s)
        {
            return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .First();

            //return s.GroupBy(char.ToLower).First(r => r.Count() == 1).Key.ToString();

        
        }
    }
}