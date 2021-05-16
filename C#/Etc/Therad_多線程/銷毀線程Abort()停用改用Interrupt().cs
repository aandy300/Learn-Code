// using System;
// using System.Threading;

// namespace MultithreadingApplication
// {
//     class ThreadCreationProgram
//     {
//         public static void CallToChildThread()
//         {
//             try
//             {

//                 Console.WriteLine("Child thread starts");
//                 // 计数到 10
//                 for (int counter = 0; counter <= 10; counter++)
//                 {
//                     Thread.Sleep(500);
//                     Console.WriteLine(counter);
//                 }
//                 Console.WriteLine("Child Thread Completed");

//             }
//             catch (ThreadAbortException e)
//             {
//                 Console.WriteLine("Thread Abort Exception:" + e);
//             }
//             finally
//             {
//                 Console.WriteLine("Couldn't catch the Thread Exception");
//             }

//         }
      
//         static void Main(string[] args)
//         {
//             ThreadStart childref = new ThreadStart(CallToChildThread);
//             // childref(); // 直接執行 不用 .Start()
//             Console.WriteLine("In Main: Creating the Child thread");
//             Thread childThread = new Thread(childref);
//             childThread.Start();
//             // 停止主线程一段时间
//             Thread.Sleep(2000);
//             // 现在中止子线程
//             Console.WriteLine("In Main: Aborting the Child thread");
//             // childThread.Abort(); // 舊的已停用 改用 Interrupt()
//             childThread.Interrupt();
            
//             Console.ReadKey();
//         }
//     }
// }