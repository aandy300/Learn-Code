// 亂數 Random #1~#3 三種方法 #4 沒有真正的亂數
// 中文教學 http://slmtsite.blogspot.com/2014/09/c30-random.html
using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int power = 100;

            // #1 沒有參數 = 0 - 2147483647
            Random r1 = new Random();
            int dmg1 = r1.Next();
            Console.WriteLine("hit:{0}", dmg1);
            // #2 maxValue 最大值 = 0 - 100
            Random r2 = new Random();
            int dmg2 = r2.Next(100);
            Console.WriteLine("hit:{0}", dmg2);

            // #3 minValue maxValue 最大與最喜值 = 50 - 100
            Random r3 = new Random();
            int dmg3 = r3.Next(power - 50, power);
            Console.WriteLine("hit:{0}", dmg3);
            // #4 沒有真正的亂數 如果 Random()裡面不填值 自動帶入時間當seed所以每次不一樣 當填入(123)時因為seed固定所以都依樣
            Random r4 = new Random(123);
            int dmg4 = r4.Next(100);
            Console.WriteLine("hit:{0}", dmg4);
            

        }
    }
}
