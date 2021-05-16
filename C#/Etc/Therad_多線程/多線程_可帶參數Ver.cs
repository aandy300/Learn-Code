// using System;
// using System.Threading;

// namespace MultithreadingApplication
// {
//     class ThreadCreationProgram
//     {
//          static void Main(string[] args)
//         {
//             Thread t1 = new Thread(new ThreadStart(TestMethod));
//             Thread t2 = new Thread(new ParameterizedThreadStart(TestMethod));
//             // 前景背景執行
//             t1.IsBackground = true;
//             t2.IsBackground = true;
//             t1.Start();
//             t2.Start("hello");
//             Console.ReadKey();
//         }

//         public static void TestMethod()
//         {
//             Console.WriteLine("不帶參數的線程函式");
//         }

//         public static void TestMethod(object data)
//         {
//             // string datastr = data as string;
//             Console.WriteLine("帶參數的線程函式，參數為：{0}", data);
//         }
//     }
// }

