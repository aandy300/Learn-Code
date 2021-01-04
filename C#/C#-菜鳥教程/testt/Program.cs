// // C# 錯誤處理
// // Err
// using System;
// namespace testt
// {
//    class TestTemperature
//    {
//       static void Main(string[] args)
//       {
//          Temperature temp = new Temperature();
//          try
//          {
//             temp.showTemp();
//          }
//          catch(TempIsZeroException e)
//          {
//             Console.WriteLine("catch_TempIsZeroException: {0}", e.Message);
//             // throw e;
//          }
         
//       }
//    }
// }
// // 自訂 異常 Class
// public class TempIsZeroException: ApplicationException
// {
//     // base(message) = public ApplicationException(string? message);
//     // 參數:
//     //   message:
//     //     A message that describes the error. // 一條描述錯誤的消息。
//    public TempIsZeroException(string message): base(message)
//    {
//    }
// }
// public class Temperature
// {
//    int temperature = 1;
//    public void showTemp()
//    {
//       if(temperature == 0)
//       {
//          throw (new TempIsZeroException("Zero Temperature found"));
//       }
//       else
//       {
//          Console.WriteLine("Temperature: {0}", temperature);
//       }
//    }
// }