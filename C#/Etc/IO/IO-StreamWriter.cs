using System;
using System.IO;

namespace FileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字
            string[] names = new string[] {"Zara Ali", "Nuha Ali"};
            // 生成
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    // 寫入文字
                    sw.WriteLine(s);
                }
            }

            // 讀取文件一行一行印出
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            
        }
    }
}