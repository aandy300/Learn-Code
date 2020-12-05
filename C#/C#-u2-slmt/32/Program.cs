// @符號 小老鼠
// 中文解說
// https://dotblogs.com.tw/billchung/2020/02/07/132935

using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // 1.限定跳脫字串
            // 沒@ 不能用
            // string s1 = "C:\Users\admin\Downloads\book";
            string s2 = @"C:\Users\admin\Downloads\book";
            Console.WriteLine(s2);
            
            // 2.字串連接跨行
            // 沒@ 不能用
//             Console.WriteLine("Hello World!
// 123
//     456
//         789");
        
            Console.WriteLine(@"Hello World!
123
    456
        789");
        }

            // 3.在識別字中的用法
            // 沒@ 不能用
            // string string = "abc";
            string @string = "abc";
    }
}
