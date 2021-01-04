// // C# 錯誤處理
// // Err
// using System;

// namespace testt
// {
//    class DivNumbers
//     {
//         int result;

//         // DivNumbers()
//         // {
//         //     result = 0;
//         // }
        
//         // public DivNumbers(){
//         //     result = 0;
//         // }

//         public void division(int num1, int num2)
//         {
//             try
//             {
//                 result = num1 / num2;
//             }
//             // DivideByZeroException 處理當除以零時生成的錯誤
//             catch (DivideByZeroException e)
//             {
//                 Console.WriteLine("Exception caught: {0}", e);
//             }
//             finally
//             {
//                 Console.WriteLine("Result: {0}", result);
//             }

//         }
//         static void Main(string[] args)
//         {
//             DivNumbers d = new DivNumbers();
//             // Console.Write(d.result);
//             d.division(25, 0);
            
//         }
//     }
// }
