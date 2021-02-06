// // 這個屬性是提供供原始程式碼偵錯工具使用;common language runtime 不受其影響。 例如，即使方法中已設定中斷點，Visual Studio 偵錯工具也不會在以這個屬性標記的方法中停止。
// https://docs.microsoft.com/zh-tw/dotnet/api/system.diagnostics.debuggerstepthroughattribute?view=net-5.0
// using System;
// using System.Runtime.CompilerServices;
// using System.Diagnostics;

// namespace TE
// {
//     class Program
//     {  
//         [DebuggerStepThrough] // 可以跳過debugger的 單步驟調適 不讓進入該方法(當確定這個方法沒有任何錯誤的時候，可以使用這個)
//         static void PrintOut(string str,[CallerFilePath] string fileName="",[CallerLineNumber] int linenNumber=0,[CallerMemberName] string methodName =""){
//             Console.WriteLine(str);
//             Console.WriteLine(fileName);
//             Console.WriteLine(linenNumber);
//             Console.WriteLine(methodName);
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");

//             PrintOut("123");
//         }
//     }
// }
