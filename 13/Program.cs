// get set 圖 精簡class func()
// #1 如果只有 get = 唯讀
// #2 get 呼叫時啟動 set 存入值時啟動
using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User p1 =  new User("andy",  "123", 100);

            Console.WriteLine(p1.compaerPassword(p1));

            Console.WriteLine(p1.get_username());
            p1.hit(12);
            Console.WriteLine(p1.get_hpstaus());

            Console.WriteLine(p1.HP);
            Console.WriteLine(p1.HP - 20);
        }
    }
}
