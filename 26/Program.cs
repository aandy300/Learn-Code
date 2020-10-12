// Martrix addition 矩陣 加法 

using System;

namespace u2_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 變數用 yx = 二維方向用 matrix_y, matrix_x = for loop用
            int y, x, matrix_y, matrix_x;
            
            // 3 x 3 的矩陣
            y = 3;
            x = 3;

            int[,] array1 = new int [10, 10];
            int[,] array2 = new int [10, 10];
            // 1+2 = 要相加的陣列 3 = 放置相加後的結果
            int[,] array3 = new int [10, 10];
            
            // 矩陣1 寫入
            Console.Write("輸入矩陣1的內容:\t");
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < x; matrix_x++){
                    // Convert.ToInt16(Console.ReadLine()); 型別轉換 string to int
                    array1[matrix_y, matrix_x] = Convert.ToInt16(Console.ReadLine());
                }
            }
            // 矩陣1 印出
            Console.WriteLine("矩陣1:");
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < x; matrix_x++){
                    Console.Write(array1[matrix_y, matrix_x]+ "\t");
                }
                Console.WriteLine();
            }

            // 矩陣2 寫入
            Console.Write("輸入矩陣2的內容:");
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < x; matrix_x++){
                    array2[matrix_y, matrix_x] = Convert.ToInt16(Console.ReadLine());
                }
            }
            // 矩陣2 印出
            Console.WriteLine("矩陣2:");
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < x; matrix_x++){
                    Console.Write(array2[matrix_y, matrix_x]+ "\t");
                }
                Console.WriteLine();
            }

            // 加法 寫進矩陣3
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < y; matrix_x++){
                    array3[matrix_y, matrix_x] = array1[matrix_y, matrix_x] + array2[matrix_y, matrix_x];
                }
            }

            // 矩陣3 印出
            Console.WriteLine("矩陣3:");
            for(matrix_y = 0; matrix_y < y; matrix_y++){
                for(matrix_x = 0; matrix_x < x; matrix_x++){
                    Console.Write(array3[matrix_y, matrix_x]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

