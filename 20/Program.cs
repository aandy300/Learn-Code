// Protected-保護  讓繼承的class內可以使用資源

using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog d1 = new Dog();
            Console.WriteLine(d1.say());
            Console.WriteLine(d1.HP);
            // ex 下面 不可用 範圍外
            // d1.info();

        }
    }
}
