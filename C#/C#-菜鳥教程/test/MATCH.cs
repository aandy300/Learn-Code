﻿using System;
using System.Text.RegularExpressions;
namespace test
{
    class MAT
    {
        static void MATCH(string[] args)
        {
            // Search for a pattern that is not found in the input string.
string pattern = "dog";
string input = "The cat saw the other cats playing in the back yard.";
Match match = Regex.Match(input, pattern);
if (match.Success )
   // Report position as a one-based integer.
   Console.WriteLine("'{0}' was found at position {1} in '{2}'.", 
                     match.Value, match.Index + 1, input);
else
   Console.WriteLine("The pattern '{0}' was not found in '{1}'.",
                     pattern, input);
        }
    }
}
