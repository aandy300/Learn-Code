// Abstract-Class-抽象class
// 把實作的內容 交給繼承的class去定義 = 強迫衍伸類別做某些功能
// Abstract-Class  不能實體化

using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Worker w1 = new Worker();
            w1.Talk();

        }
    }
}

