// Array 陣列 儲存相同類型的資料  圖

// 一開始就要宣好大小(或用動態陣列解決) 
// 產生時 int 預設填入 0 double 0.0 bool false 
// (物件陣列)類似point ex people[1] = 地址 指向 Heap(堆疊)資料儲存的位置

// 中文教學 SLMT's Tutorial Blog 
// http://slmtsite.blogspot.com/2013/08/c-22-array.html


using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] count = new int[5];
            count[0] = 11;
            count[1] = 22;
            count[2] = 33;
            Console.WriteLine("int count array");
            Console.WriteLine(count[2]);

            int[] agelist = new int[]{22,33,44,55};
            Console.WriteLine("age list array");
            Console.WriteLine(agelist[0]);
            Console.WriteLine(agelist[3]);

            Person[] people = new Person[5];
            people[0] = new Person("a", "aa", 10);
            people[1] = new Person("b", "bb", 20);
            people[2] = new Person("c", "cc", 30);
            Console.WriteLine("people list array");
            Console.WriteLine("people[0]_info: {0}", people[0].Info());
            Console.WriteLine("people[1]_info: {0}", people[1].Info());
            Console.WriteLine(people[2]);
            
        }
    }
}
