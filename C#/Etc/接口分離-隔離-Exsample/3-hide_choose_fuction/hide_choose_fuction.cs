// // 隱藏特定fuction

// using System;
// namespace IspExsample3{

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");

//             var K = new WarmKiller();
//             K.Love();
//             IKiller K2 = new WarmKiller();
//             K2.kill();
//         }
//     }

//     interface IGentleman{
//         void Love();
//     }
//     interface IKiller{
//         void kill();
//     }
//     class WarmKiller: IGentleman, IKiller{
//         public void Love(){
//             Console.WriteLine("LOVE");
//         }
//         void IKiller.kill(){
//             Console.WriteLine("Kill2");
//         }

//     }

// }
