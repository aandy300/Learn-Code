// 自訂特性 與 使用
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace TE
{
    // 當使用自訂特性時，後面的Attribute不需要寫
    // 當在尋找特性時會自動在最後追加Attribute然後對應到該特性上
    // 通過屬性稱，給屬性賦予值,這種行稱為 命名參數
    [MyTest("自訂特性測試",ID = 100)] 
    class Program
    {  
        [DebuggerStepThrough] // 可以跳過debugger的 單步驟調適 不讓進入該方法(當確定這個方法沒有任何錯誤的時候，可以使用這個)
        static void PrintOut(string str,[CallerFilePath] string fileName="",[CallerLineNumber] int linenNumber=0,[CallerMemberName] string methodName =""){
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(linenNumber);
            Console.WriteLine(methodName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintOut("123");

            // 知道一個類 使用到那些特性 
            Type type = typeof(Program); // 通過typeof + 類名也可以獲得type對象
            object[]  array = type.GetCustomAttributes(false); // 參數 是否搜索繼承的類使用的特性 true or false
            MyTestAttribute mytest = array[0] as MyTestAttribute; // 轉換為相應特性 並 轉存  # as 如果兼容轉存 不能null
            Console.WriteLine(mytest.Description);
            Console.WriteLine(mytest.ID);

            // as轉換規則：
            // 1.檢查物件兼容性，返回轉換結果，如果不兼容返回NULL
            // 2.不會拋出異常
            // 3.如果結果判斷空，則強制執行類型轉換拋出NullReferenceException異常
        }
    }
}
