// List-串列-列表
// 官方文件
// https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic.list-1?view=netcore-3.1
// 延伸 slmtsite.blogspot 
// List 的 Remove 與 Contains 判斷相等的方式
// List 的 Sort 如何比較大小？
// https://slmtsite.blogspot.com/2020/10/c-sharp-49-list.html

using System;
using System.Collections.Generic;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = new List<int>();
            
            list.Add(123);
            list.Add(456);
            list.Add(9);
            list.Add(8);
            list.Add(7);
            list.Add(4);
            list.Add(2);
            list.Add(1);

            for (int i = 0; i < list.Count; i++){
                Console.Write(list[i] + " ");    
            }
            Console.WriteLine("sort前");

            // Sort() 造順序排好內容
            list.Sort();
            
            for (int i = 0; i < list.Count; i++){
                Console.Write(list[i] + " ");    
            }
            Console.WriteLine("sort後");
            
            // 印出指定位置
            Console.WriteLine(list[0]);
            // Remove(***) 移除 *** 後面的自動補上位置
            list.Remove(123);
            // Remove(index) 移除指定位置的值
            list.RemoveAt(6);
            // Contains(***) 檢查是否有 ***
            Console.WriteLine(list.Contains(123));
            // Count 現在長度/有幾個物件
            Console.WriteLine(list.Count);
            
            


        }
    }
}
