// C# 矩陣 加法 https://www.tutorialspoint.com/How-to-perform-Matrix-Addition-using-Chash

using System;

namespace u2_C_
{
    class martrix
    {
        static void ain(string[] args)
        {
            Console.WriteLine("Hello World!");

            int m, n, i, j;
   
            Console.Write("Enter number of rows and columns of the matrix ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());

            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];

            // 輸入 矩陣1 內容
            // m = 3 n = 3
            Console.Write("Enter elements - Matrix 1 : ");
            for (i = 0; i < m; i++) { // 0 1 2
                for (j = 0; j < n; j++) { // 0 1 2 
                // 寫入
                arr1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.Write("Enter elements - Matrix 2 : ");
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                arr2[i, j] = Convert.ToInt16(Console.ReadLine());
                }  
            }


            // 印出
            Console.WriteLine("Matrix 1 ");
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                Console.Write(arr1[i, j] + "\t");
            }
            Console.WriteLine();
            }

            Console.WriteLine("Matrix 2 ");
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                Console.Write(arr2[i, j] + "\t");
            }
            Console.WriteLine();
            }
            
            // Addition
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            Console.WriteLine();
            }

            // 印出 Addition
            Console.WriteLine("Matrix Addition ");
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.Write(arr3[i, j] + "\t");
            }
            Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

