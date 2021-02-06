// // 大陸 宏 = 巨集
// // #define IsTest // 定義一個巨集 利用 條件名稱 有效化功能
// using System;
// using System.Diagnostics;

// namespace TE
// {
//     class Program
//     {  
//         // 無效化特定功能 如果要有效 在最開始使用 #define 條件名稱
//         // [Conditional("條件名稱")]
//         [Conditional("IsTest")]
//         static void test1(){
//             Console.WriteLine("test1");
//         }
//         static void test2(){
//             Console.WriteLine("test2");
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");

//             test1();
//             test2();
//             test1();
//         }
//     }
// }
