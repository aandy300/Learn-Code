// static 靜態型別 圖
// 中文教學 http://slmtsite.blogspot.com/2013/07/c-19-static.html
// 不用建立物件就可以使用有 static 的 func()和屬性 ex Person.pass_age = 1;
// 同 class的物件 共用此 屬性
// static calss 不能建立物件

using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Person p1 = new Person("a", "123", 12);
            // Person p2 = new Person("b", "343", 22);
            // Person p3 = new Person("c", "444", 92);

            // static 不用 new 產生物件 就能直接使用
            Console.WriteLine(Person.addmath(50,10));
            Console.WriteLine(Person.checkage(10));
            Console.WriteLine(Person.checkage(30));
            Person.pass_age = 1;
            Console.WriteLine("Person pass age > 1");
            Console.WriteLine(Person.checkage(30));
            Console.WriteLine(Person.checkage(10));           
            
        }
    }
}
