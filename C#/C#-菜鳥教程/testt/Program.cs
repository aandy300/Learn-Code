using System;
using System.Text.RegularExpressions;
namespace testt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Search for a pattern that is not found in the input string.
            string pattern = @"123";
            string input = "ABC123 847 555";
            Match match = Regex.Match(input, pattern);
            Console.WriteLine(match);
            if (match.Success )
            // Report position as a one-based integer.
            Console.WriteLine("'{0}' was found at position {1} in '{2}'.", 
                                match.Value, match.Index , input);
            else
            Console.WriteLine("The pattern '{0}' was not found in '{1}'.",
                                pattern, input);
        }
   }
}
