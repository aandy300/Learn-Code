// Multidimensional-Array-多維陣列 圖

// 超過陣列範圍 當下不會反應 編譯時會出BUG
// C# 矩陣 看法 Y > X > Z | 上到下 左到右 內到外

// 多維陣列 (C# 程式設計手冊)
// https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

// 矩陣 https://zh.wikipedia.org/wiki/%E7%9F%A9%E9%98%B5
// 矩陣乘法 https://zh.wikipedia.org/wiki/%E7%9F%A9%E9%99%A3%E4%B9%98%E6%B3%95

using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int[, ,] array3D = new int[,,] { { { 1, 2}, { 3, 4 } },
                                           { { 5, 6}, { 7, 8 } } };

            Console.WriteLine(array3D[1,1,1]);

            // 一維 宣告時 放入數值
            int[] D;
            D = new int[] {12, 345, 67};

            // 二維 宣告時放入
            int[,] E;
            E = new int[,]{ {0, 1}, {2, 3}};
            int[,] G = new int[,]{ {0, 1}, {2, 3}};

            // 三維 宣告時放入
            int[,,] F;
            F = new int[,,]{{ {0, 1}, {2, 3}, {4, 5}, {6, 7} }};

            // 宣告並建立一個長度為 2 的一維陣列
            int [] A = new int[2];
            // 宣告並建立一個 2 x 3 的二維陣列
            int[,] B = new int[2,3];
            // 宣告並建立一個 2 x 3 x 4 的三維陣列
            int[,,] C = new int[2,3,4];

            // 將 A 中位置為 1 的值改成 10
            A[1] = 10;
            // 將 B 中位置為 (1, 0) 的值改成 42
            B[1, 0] = 42;
            // 將 C 中位置為 (0, 2, 1) 的值改成 25
            C[0, 2, 1] = 25;

        }
    }
}
