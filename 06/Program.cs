// 建構子-Constructor 多載 Overloaded 圖
// 中文教學 http://slmtsite.blogspot.com/2013/04/c-17-constructor.html
using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 有建構子後 new 產生新物件時 直接輸入屬性資訊
            // 如果有 多載 沒有輸入的資訊 自動載入多載設定的內容 
            // Ex: 沒輸入age 多載設定自動填入 99
            Person p1 = new Person("ming", "lee", 30);
            Person p2 = new Person("dpcs", "mint");

            Console.WriteLine(p1.Info());
            Console.WriteLine(p2.Info());
        }
    }
}
