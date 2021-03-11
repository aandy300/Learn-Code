// 反射 依賴注入
// dotnet平台有兩個大的版本 dotnet code 和 dotnet framework (dotnet code未來) API類似
// 反射 對象的描述 用 描述創建新的對象 (重製)
// ex unity 引用 prefab > 更改 prefab內容 引用的也會一起更改 可以改部分 其他的也跟著一起改動
// 依賴反轉 概念 + 結合接口 = 依賴注入

// 依賴注入 最重要的東西 > 容器
// 將各種註冊的類型,接口放入容器
// 要實例時跟容器要就好
using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
namespace DI_Dependency_Injection_Exsample
{

    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection(); // = 容器
                                              // 下面 ITank 是靜態 typeof(目標) 才可以拿到動態的 // 裝東西 當前的函數裡面Scoped要對上 哪個接口ITank 哪個類實現這個接口 > 類型 放進容器 
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(IVehicle), typeof(Car));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            // -----------以上為一次性的註冊-------------- //
            // 註冊的好處 > 如果程式升級 ITank 對應更改 變成 MediumTank 
            // 只需要把 sc.AddScoped(typeof(ITank),typeof(HeavyTank));  改成 sc.AddScoped(typeof(ITank),typeof(MediumTankTank));  就都改了 省工程次數
            // ex unity 引用 prefab > 更改 prefab內容 引用的也會一起更改
            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();
            // 上面註冊的是 sc.AddScoped(typeof(IVehicle), typeof(Car));
            // 當要創建 Driver 時 需要一個IVehicle的實例 上面IVehicle註冊的是Car 所以直接帶入Car
            var driver = sp.GetService<Driver>();
            driver.Drive();
            // 依賴注入 總結 ex unity 引用 prefab > 更改 prefab內容 引用的也會一起更改 可以改部分 其他的也跟著一起改動
        }
    }

    interface IVehicle
    {
        void Run();
    }
    interface IWeapon
    {
        void Fire();
    }
    interface ITank : IVehicle, IWeapon
    {
        new void Fire();
        new void Run();
    }
    class Driver
    {
        private IVehicle _vehicele;
        // 建構子
        public Driver(IVehicle vehicle)
        {
            _vehicele = vehicle;
        }

        public void Drive()
        {
            _vehicele.Run();
        }
    }
    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is runing...");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("truck is runnuing");
        }
    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("LightTank boom!");
        }
        public void Run()
        {
            Console.WriteLine("LightTank kakaka!");
        }
    }
    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("MediumTank boom!");
        }
        public void Run()
        {
            Console.WriteLine("MediumTank kakaka!");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("HeavyTank boom!");
        }
        public void Run()
        {
            Console.WriteLine("HeavyTank kakaka!");
        }
    }
}