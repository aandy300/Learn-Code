// 圖 Value 與 Reference Type 參考型別 類似 point? 直接修改地址裡面的資料
// 建構子 會在記憶體地址的 "裡面" 堆疊
// https://zh.wikipedia.org/zh-tw/%E6%9E%84%E9%80%A0%E5%99%A8#C#
// Heap 堆疊
// https://zh.wikipedia.org/zh-tw/%E5%A0%86%E7%A9%8D

using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello World!";
            Console.WriteLine(x);

            Person p1 = new Person();
            p1.firstname = "ming";
            p1.lastname = "lee";
            p1.age = 30;

            Console.WriteLine(p1.Info());
            // output:
            // Name:ming lee
            // Age:30

            Person p2 = p1;
            p2.firstname = "mint";
            p2.lastname = "dpcs";
            p2.age = 99;
            Console.WriteLine(p1.Info());
            // output:
            // Name:mint dpcs
            // Age:99

        }
    }
}
