// private 運用案例 圖
// #1 隱藏數值 在class裡面運算再傳答案出來
// #2 唯讀 同上(只傳達案不能修改參數)
// #3 限制使用func()才能修改屬性 (統一方法?)

using System;

namespace _12
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

        }
    }
}
