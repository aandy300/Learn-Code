// for while if
using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 0;
            
            // while(i <= 5)
            // {
            //     Console.WriteLine("i: {0}", i);
            //     i++;
            // }

            if (i <= 5){
                for (int count = 1; count <= 10;){
                    i++;
                    count++;
                    Console.WriteLine("i: {0} count: {1}", i, count);
                }
            }
            else{
                Console.WriteLine("i: {0}", i);
            }
        }
    }
}
