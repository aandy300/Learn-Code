﻿// using System;
// using System.Text.RegularExpressions;

// public class Example
// {
//    public static void Main()
//    {
//       string[] partNumbers= { "B1298-673-4192", "A08Z-931-468A", 
//                               "_A90-123-129X", "12345-KKA-1230", 
//                               "0919-2893-1256C" };

//       // var x = "123";
//       // Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
//       // Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}$");
//       // foreach (string partNumber in partNumbers)

//       // Console.WriteLine("{0} {1} a valid part number.", partNumber, rgx.IsMatch(partNumber) ? "is" : "is not");
      
      
//       string pattern = @"[A-Z]";
//       Regex regex = new Regex(pattern);
//       // 因為是array所以用 for 一個一個印出 轉成 str
//       foreach(string str in partNumbers){
//          MatchCollection matches = regex.Matches(str);
         
//          // Console.WriteLine(partNumbers.Length);
//          // Console.WriteLine(matches[0]);
//          foreach(Match ss in matches){
//             Console.Write(ss);
//          }
//          Console.WriteLine();
//       }
      
//       // foreach(string str in partNumbers){
//       //    MatchCollection matches = regex.Matches(str);
//       //    foreach(Match ma in matches){
//       //       GroupCollection groups = ma.Groups;
//       //       Console.WriteLine(   ": " + groups["word"].Value.Trim());
//       //    }
//       // }
      
      
//    }
// }