// using System;
// using System.IO;

// namespace FileApplication
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             string File_path = @"C:\Users\admin\Desktop\test.txt";

//             try
//             {   
//                 // StreamReader Class 時座椅特定的編法方式自位元組資料流讀取字元的 TextReader
//                 // 創建一個 StreamReader 的實例來讀取文件
//                 // using 語句也能關閉 StreamReader
//                 using (StreamReader sr = new StreamReader(File_path))
//                 {
//                     string line;
                    
//                     // 讀取文件一行一行印出直到文件的尾端
//                     while ((line = sr.ReadLine()) != null)
//                     {
//                         Console.WriteLine(line);
//                     }
//                 }
//             }
//             catch (Exception e)
//             {
//                 // 顯示err
//                 Console.WriteLine("The file could not be read:");
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }