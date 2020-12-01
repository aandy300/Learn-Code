// const 常數 readonly 讀取
// 常數 不會被修改的值 編譯時替換成特定的值
// readonly 執行時再去查詢

// Q const 編譯時會固定 改版後新的版本近來沒辦法改動
// A 改用readonly

// 中文教學 http://slmtsite.blogspot.com/2016/10/c-36-constant.html

using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double atk = 10.0;

            Console.WriteLine(atk * Monster.DAMAGE_MULTIPULIER);
        }
    }
}
