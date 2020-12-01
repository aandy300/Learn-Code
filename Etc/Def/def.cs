// C# 預處理器 指令 圖

// 規則:
// 所有指令都是以 # 開始 且在一行之上 只有 空白 可以出現在預處理器指令前
// 預處理器指令不是語句，所以它們不用以(;)結束

// C# 预处理器指令列表...

// #define 預處理器創建符號常量
// 圖
// # 條件指令
// 圖, if etc...
// #warning 和 #error 類似Go自訂Err
// 如果遇到Err會印出後面的文本後繼續編藝進行。(run前)
// 如果編譯器遇到Err會給出後面文本作為錯誤訊息然後退出編譯。(run後)
// 簡易版: Err 中斷 log  War 警告 log only
// #region 和 #endregion
// 可以折疊 #region = 開始範圍 #endregion = 結束範圍
// #line 
// 改變.cs名稱 & 行數位置
// #line = 以下開始更改log資訊 #line default = 回復預設
// #pragma 抑制警告訊息
// #pragma warning disable = 以下開始取消警告訊息 #pragma warring restore = 以下開始恢復警告訊息 

#define PI
// #define DEBUG
// #define RELEASE
using System;
namespace PreprocessorDAppl
{
   class Program
   {
      int t;
      static void Main(string[] args)
      {
      //  if else
      #if (PI)
         Console.WriteLine("PI is defined");
      #else
         Console.WriteLine("PI is not defined");
      #endif
         
      //  #warning 和 #error：
      #if DEBUG && RELEASE  
         #error "You've defined DEBUG and RELEASE simultaneously!"  
         #endif  
         #warning "Don't forget to remove this line before the boss tests the code!"  
      Console.WriteLine("*I hate this job.*");

      // #region 可以折疊 #endregion 結束範圍
      #region Member Field Declarations
      int x;
         Console.WriteLine("可以折疊");
         Console.WriteLine("可以折疊");
         Console.WriteLine("可以折疊");
      #endregion

      // #line 更改log資訊 #line default 回復預設
      #line 164 "Core.cs" // 在文件的第 164 行
         // Core.cs, before the intermediate
         // package mangles it.
         // later on
         int y;
      #line default // 恢复默认行号

      if(true)
      {
         Console.WriteLine("true");
      }

      // #pragma 抑制警告訊息

      // 抑制警告訊息(作用中)
      #pragma warning disable
      if (false)
      {
         Console.WriteLine("偵測到執行不到的程式碼");
      }
      #pragma warning restore

      // #pragma 指定 目標行數ver
      #pragma warning disable 82, CS0162
      if (false)
      {
         Console.WriteLine("偵測到執行不到的程式碼");
      }
      #pragma warning restore
      
      // #pragma 對照用(會產生警告)
      if (false)
      {
         Console.WriteLine("偵測到執行不到的程式碼");
      }

      // 參考用
      // #pragma warning disable 169    // 取消编号 169 的警告（字段未使用的警告）
      // public class MyClass
      // {
      //    int neverUsedField;       // 编译整个 MyClass 类时不会发出警告
      // }
      // #pragma warning restore 169   // 恢复编号 169 的警告

      }
   }

}