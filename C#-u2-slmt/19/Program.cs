// # 19-Override-Method-Hiding 圖
// func() 以 baseclass(Fruit) 使用 or 自身(Bana) 使用
// new 用來區分 是否是 隱藏

// 呼叫同名func()時  優先順序為 看你以哪個CLASS呼叫他



using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Apple a1 = new Apple();
            Console.WriteLine(a1.say());
            Bana b1 = new Bana();
            Console.WriteLine(b1.say());
            Fruit c = b1;
            Console.WriteLine(c.say());
        }
    }
}
