// # get set 練習 http://slmtsite.blogspot.com/2013/10/c-26-get-set.html
// value = 外面算式的總和 "結果"
using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player p1 = new Player();
            p1.pickACopper();
            p1.pickASilver();
            p1.pickAGold();
            Console.WriteLine("全金額:{0}", p1.TotalG);

            Console.WriteLine("\n分隔線 -----------------");
            Console.WriteLine("原生命:{0}", p1.HungerRate);
            Console.WriteLine("增加的數:{0}", p1.HungerRate += 100000000);
            Console.WriteLine("調整上限後的生命:{0}", p1.HungerRate);
            
            Console.WriteLine("\n分隔線 -----------------");
            Console.WriteLine("原生命:{0}", p1.HungerRate);
            Console.WriteLine("減少的數:{0}", p1.HungerRate -= 100000000);
            Console.WriteLine("調整上限後的生命:{0}", p1.HungerRate);
        }
    }
}
