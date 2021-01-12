// using System;
// using System.IO;

// namespace testt
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             // 超過數值會變 -1
//             FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

//             for (int i = 0; i <= 20; i++)
//             {
//                 F.WriteByte((byte)i);
//             }

//             F.Position = 9;
//             for (int i = 0; i <= 20; i++)
//             {
//                 Console.Write(F.ReadByte() + " ");
//             }
//             F.Position = 0;
//             for (int i = 0; i <= 20; i++)
//             {
//                 Console.Write(F.ReadByte() + " ");
//             }
//             F.Close();
            
//         }
//     }
// }