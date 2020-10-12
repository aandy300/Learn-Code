// switch enum 列舉
// switch 結構簡單點 省資源
// enum 列舉 類似 go iota = 創造新型別 = 值
// default: break; 如果都不符合 類似else

using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Monster m1 = new Monster();
            Console.WriteLine(m1.ReportPostion());
            m1.Move(Direction.UP);
            Console.WriteLine(m1.ReportPostion());
        }
    }
}
