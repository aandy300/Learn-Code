// using System;

// namespace TE
// {
//     class Program
//     {   
//         [Obsolete("備註:這個方法過時了, 使用 NewMethod()")] // 用來表示一個方法 已經過時
//      // [Obsolete("備註:這個方法過時了, 使用 NewMethod()", true)] // 用來表示一個方法 已經過時
//         static void OldMethod(){
//             Console.WriteLine("old");
//         }
//         static void NewMethod(){
//             Console.WriteLine("new");
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//             OldMethod();
//             NewMethod();
//         }
//     }
// }
