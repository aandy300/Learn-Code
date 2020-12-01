// 複寫-Override
// 繼承的class 改寫 baseclass的功能
// #1 baseclass 要改寫的前面需加 virtual
// #2 Override的class 要宣一個 名稱與參數皆相同的FUNC(), 前方需加 Override
using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player p1 = new Player("ming");
            Monster m1 = new Monster("Monster");
            Npc n1 = new Npc("Npc");

            Console.WriteLine(n1.Atk(m1));
            Basedata b = n1;
        }
    }
}
