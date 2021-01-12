using System;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            // 抓c:\Windows 目錄信息 存入 mydir
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");

            // 获取目录中的文件以及它们的名称和大小
            // 抓取file資訊存入array
            // foreach 一筆一筆印出 file.name file.Length
            FileInfo [] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}",
                    file.Name, file.Length);
            }
            
        }
    }
}