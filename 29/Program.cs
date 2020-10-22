// 多型性-Polymorphism
// 跳過 五子 五子用unity


using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Villager v1 = new Villager("生物");
            Console.WriteLine(v1.HP);
            v1.talk();

            Player p1 = new Player("ming");
            Console.WriteLine(p1.HP);
            p1.talk();
            
            v1 = p1;
            Console.WriteLine(v1.HP);
            v1.talk();
        }
    }
}
