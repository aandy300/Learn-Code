// using System;
// using System.Text.RegularExpressions;

// public class Example
// {
//    public static void Main()
//    {
//     //原始字串
//     string input = "The men's soft tennis team captured the first gold medal for Taiwan "
//                 + "yesterday in the 2010 Asian Games in Guangzhou, China, while their " 
//                 + "female counterparts garnered a silver for Taiwan, which is competing " 
//                 + "as Chinese Taipei at the regional sport games.";
//     //規則字串 
//     string pattern = @"\d+";
    
//     foreach (Match match in Regex.Matches(input, pattern))
//     Console.WriteLine(match.Value);
    
//     // string pattern = @"(?\sc[\w]*)";
//     //宣告 Regex 忽略大小寫 
//     Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
//     //將比對後集合傳給 MatchCollection 
//     MatchCollection matches = regex.Matches(input); 
//     int index = 0;
//     // 一一取出 MatchCollection 內容
//     foreach (Match match in matches) 
//     {
//         // 將 Match 內所有值的集合傳給 GroupCollection groups
//         GroupCollection groups = match.Groups;
//         // 印出 Group 內 word 值
//         Console.WriteLine( ++ index + ": " + groups["word"].Value.Trim()); 
//     }

//    }
// }