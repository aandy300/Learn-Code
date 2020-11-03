// recursion 遞迴 遞歸 圖
using System;

namespace recursion
{
    class NumberManipulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NumberManipulator n = new NumberManipulator();
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            // Console.ReadLine();
        }
        // 递归
         public int factorial(int num)
        {
            /* 局部变量定义 */
            int result;

            if (num == 1)
            {   
                Console.WriteLine(":= 1");
                return 1;
            }
            else
            {   
                Console.WriteLine("in");
                Console.WriteLine(":" + num);
                result = factorial(num - 1) * num;
                Console.WriteLine("out");
                Console.WriteLine(num + "num");
                Console.WriteLine(result + "result");
                return result;
            }
        }
    }
}
