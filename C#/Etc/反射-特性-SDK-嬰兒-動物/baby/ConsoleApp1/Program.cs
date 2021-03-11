using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Loader;
using BabyStroller.SDK;
using System.Linq;

namespace BabyStroller
{
    class Program
    {
        static void Main(string[] args)
        {
            // 印出運行的文件夾
            Console.WriteLine(Environment.CurrentDirectory);
            // 路徑轉存 抓Animals資料夾存到 floder
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            Console.WriteLine(folder);
            // 抓路徑裡的資料 轉存
            var files = Directory.GetFiles(folder);
            // 將 之後要進來的 動物Class存近來 (現階段是0 空的) 後面add加入
            var animalTypes = new List<Type>();

            foreach (var file in files) {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                // 上面讀去file 把抓進來的轉存到 types
                // 在沒有SDK時的情況 很多都要重複手工操作
                var types = assembly.GetTypes();
                //  如果讀進來的 有 Voice Method 追加近 animalTypes
                foreach (var t in types) {
                   
                    // 有SDK前
                    //if (t.GetMethod("Voice") != null) {
                    //    animalTypes.Add(t);
                    //}
                    // 有SDK後 只要確認是否是 IAnimal 和是否 [Unfinished]
                    // 如果有 IAnimal Interface
                    if (t.GetInterfaces().Contains(typeof(IAnimal))){
                        var isUnfinished = t.GetCustomAttributes(false).Any(a => a.GetType() == typeof(UnfinishedAttribute));
                        if (isUnfinished) continue;
                        animalTypes.Add(t);
                    }
                }
            }

            while (true) {
                for (int i = 0; i < animalTypes.Count; i++) {
                    // ?? $
                    // 通常程式時是 0 但  用戶在使用時是 1up 這裡用戶
                    Console.WriteLine($"{i + 1}.{animalTypes[i].Name}");
                }
                Console.WriteLine("---------------------");
                Console.WriteLine("plz choose animal");
                // Parse(強制轉型)
                // 讓用戶在命令行裡輸入一 個整數
                // 如果不存在 LOOP
                int index = int.Parse(Console.ReadLine());
                if (index > animalTypes.Count || index < 1) {
                    Console.WriteLine("no such an animal. try again!");
                    continue;
                }

                Console.WriteLine("how many times?");
                // 若有 再輸入一次 讓動物叫 ? 次
                int times = int.Parse(Console.ReadLine());
                // 通常程式時是 0 但  用戶在使用時是 1up 這裡程式
                var t = animalTypes[index - 1];
                // var m = t.GetMethod("Voice"); // 沒用到
                // Activator.CreateInstance = 使用最符合指定之參數的建構函式，建立指定之類型的執行個體。
                var o = Activator.CreateInstance(t);
                // 調用方法  但 帶入參數 type
                // 在 o 上面執行 > 需要把參數傳進來(以對象數組(array)的方式 new obj[])

                // object? System.Reflection.MethodBase.Invoke(object? ong, obhect?[]? parameters) 格式

                // ? {  time } 次數 但 {}?
                // ??前面的課 dotnet系統是單根的?
                // m.Invoke(o, new object[] { times });
                var a = o as IAnimal;
                a.Voice(times);

            }
        }
    }
}
