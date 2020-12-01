// 繼承性 繼承基底後可以用基底的功能
// 同樣的FUNC()可以只打在基底節省重複性

using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person();
            Monster m1 = new Monster();
            Console.WriteLine("名稱:{0} \n生命:{1}", p1.Nameinfo, p1.Hpinfo);
            m1.Atk(p1);
            Console.WriteLine("名稱:{0} \n生命:{1}", p1.Nameinfo, p1.Hpinfo);
        }
    }
}
