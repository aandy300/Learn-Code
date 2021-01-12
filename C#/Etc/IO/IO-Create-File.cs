// using System;
// using System.IO;

// namespace FileApplication
// {
//     class Program
//     {
        
//         static void Main(string[] args)
//         {
//             string path = @"C:\Users\admin\Desktop\test123.txt";
//             //如果找不到
//             if (!File.Exists(path))
//             {    
//                 // 生成文件並寫入
//                 // Create a file to write to.
//                 using (StreamWriter sw = File.CreateText(path))
//                 {
//                     sw.WriteLine("Hello");
//                     sw.WriteLine("And");
//                     sw.WriteLine("Welcome");
//                 }	
//             }              

//         }
//     }
// }