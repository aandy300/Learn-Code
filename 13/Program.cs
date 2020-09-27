// get set 圖
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
