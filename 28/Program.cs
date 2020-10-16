// 28-Multidimensional-Array-多維陣列-乘法 圖
// 教學
// https://www.tutorialspoint.com/chash-program-to-multiply-two-matrices
using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 先宣變數
            int array1_y = 2, array1_x = 3, array2_y = 3, array2_x = 3, count_y, count_x;
            // 宣矩陣 塞內容
            int[,] array1 = {{1, 4, 2}, {2, 5, 1}};
            int[,] array2 = {{3, 4, 2}, {3, 5, 7}, {1, 2, 1}};

            Console.WriteLine("矩陣1:");
            for(count_y = 0; count_y < array1_y; count_y++){
                if(count_y == array1_y - 1){
                    Console.WriteLine();
                }
                for(count_x = 0; count_x < array1_x; count_x++){
                    Console.Write(array1[count_y, count_x]+ "  ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("矩陣2:");

            for(count_y = 0; count_y < array2_y; count_y++){
                for(count_x = 0; count_x < array2_x; count_x++){
                    Console.Write(array2[count_y, count_x]+ "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 乘法
            // 00   00   01  10   02   20     00  01  01  11   02  21
            // 1  *  3 + 4  * 3  + 2 * 1  ||  1 * 4 + 4 *  5 +  2 *  2

            // 如果第一個矩陣中的列數不等於第二個矩陣中的行數，則矩陣不能相乘並顯示出來。
            if(array1_x != array2_y){
                Console.Write("矩陣A_x ≠ 矩陣B_y不等於, 矩陣不能相乘");
            }else{
                // 宣array3 int[array1_y, array2_x] 2 * 3 size
                int[,] array3  = new int[array1_y, array2_x];
                // y,x loop 放入 0
                for(count_y = 0; count_y < array1_y; count_y++){
                    for(count_x = 0; count_x < array2_x; count_x++){
                        array3[count_y, count_x] = 0;
                        // k = 進loop時記數用 = array_1_x 橫向 也可用於直向 array_2_y 乘的次數 0 1 2 再次進來時重製為0
                        for(int k = 0; k < array1_x; k++){
                            // 乘法結果 放入 array3 
                            //                                 k = x橫向             k = y直向
                            array3[count_y, count_x] += array1[count_y, k]  * array2[k, count_x];
                            // 觀測用
                            // Console.Write(array3[count_y, count_x]);
                        }
                    }
                }
                Console.WriteLine("矩陣3:");
                for(count_y = 0; count_y < array1_y; count_y++){
                    for(count_x = 0; count_x < array2_x; count_x++){
                        Console.Write(array3[count_y, count_x]+ "  ");
                    }
                Console.WriteLine();
                }
            }
        }
    }
}
