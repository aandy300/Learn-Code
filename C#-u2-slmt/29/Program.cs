// 多型性-Polymorphism
// 跳過 五子 五子用unity

// 封裝性
// 將資料包裝在物件李
// 繼承性
// class繼承其他class的屬性與行為,降低重複性
// 多形性
// 利用統一介面存取物

using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Creature v1 = new Creature("生物");
            Console.WriteLine(v1.HP);
            v1.talk();

            Player p1 = new Player("ming");
            Console.WriteLine(p1.HP);
            p1.talk();
            
            v1 = p1;
            Console.WriteLine(v1.HP);
            v1.talk();

            Monster m1 = new Monster();
            m1.atk(v1);
            Console.WriteLine(v1.HP);
        }
    }
}
