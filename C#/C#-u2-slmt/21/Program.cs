// base 類似 this 只是指的是基底

// 中文教學
// http://slmtsite.blogspot.com/2016/05/c-34-base.html

// 1. 衍生類別 有 同名屬性時 呼叫"基底類別"的屬性
// 2. 要使用override掉的  "原本class部分func()內容"時  
// 3. 想要呼叫基底類別的建構子時

using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog d1 = new Dog("dog1");
            d1.gethp();
            Console.WriteLine(d1.info());
            Console.WriteLine(d1.HP);
            
        }
    }
}
