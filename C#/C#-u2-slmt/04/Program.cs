// class 和 生成新OBJ 圖
// 類似 go type

using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 指定class p = 容器 new = 生成新物件 person()
            Person p1 = new Person();
            // 輸入屬性
            p1.firstname = "andy";
            p1.lastname = "ming";
            p1.age = 29;
            // 跑 person.Info() 功能
            Console.WriteLine(p1.Info());

            Person p2 = new Person();
            p2.firstname = "david";
            p2.lastname = "lee";
            p2.age = 11;
            
            Console.WriteLine(p2.Info());
            p2.Addage();
            Console.WriteLine(p2.Info());
            Console.WriteLine(p2.Talk(p1));
        }
    }
}
