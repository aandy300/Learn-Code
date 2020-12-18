// using System;
// using System.Text.RegularExpressions;

// public class Exsample
// {
//    public static void Main()
//    {
    
//       // 原始字串
//       string[] partNumbers= { "B1298-673-4192", "A08Z-931-468A", 
//                         "_A90-123-129X", "12345-KKA-1230", 
//                         "0919-2893-1256C" };
//       // 規則條件 @ = 跳脫字節
//       string pattern = @"[A-Z]";

//       Regex regex = new Regex(pattern);
//       // 因為是array所以用 for 一個一個印出 轉成 str
//       foreach(string str in partNumbers)
//       {
//          MatchCollection matches = regex.Matches(str);

//          foreach(Match match in matches)
//          {
//             Console.Write(match);
//          }

//          Console.WriteLine();
//       }
//    }
// }