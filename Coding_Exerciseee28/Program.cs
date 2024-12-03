using System.Text.RegularExpressions;

namespace Coding_Exerciseee28
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string input = "Contact us at support@example.com or sales@example.org.";
                ExtractPatterns(input);
        }
        public  static void ExtractPatterns(string input)
        {

            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";


            MatchCollection matches = Regex.Matches(input, pattern);


            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
