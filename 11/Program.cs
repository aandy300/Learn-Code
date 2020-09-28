// 封裝性 public and private 
using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person();
            
            // private 無法在自己以外使用
            p1.age = 1 ;

        }
    }
}
