// // 反射 依賴注入 範例
// // dotnet平台有兩個大的版本 dotnet code 和 dotnet framework (dotnet code未來) API類似
// // 反射 對象的描述 用 描述創建新的對象 (重製)
// // 依賴反轉 概念 + 結合接口 = 依賴注入

// using System;
// using System.Reflection;
// // using Microsoft.Extensions.Dependencylnjection;
// namespace IspExsample1{

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             ITank tank = new HeavyTank();
//             // -------------分割線以下不再用靜態類型------------- //
//             // 上面 ITank tank new HeavyTank 都是靜態
//             // GetType() = 抓 tnak 的動態資訊(記憶體裡) 回傳type class
//             var t = tank.GetType();
//             // Activator.CreateInstance(t) > 回傳 object class
//             object o = Activator.CreateInstance(t);
//             // 用反射機制調用 fire() run()
//             MethodInfo fireMi = t.GetMethod("Fire");
//             MethodInfo runMi = t.GetMethod("Run");
//             // 要在 o 上 跑上面這些方法
//             // 調用 Invoke
//             fireMi.Invoke(o, null);
//             runMi.Invoke(o, null);
//             // ------以上為從記憶體調用資訊 沒有任何靜態類型 -----//
//             // 以上反射機制範例
//             // PS 通常使用反射時都是使用封裝好的 不會像這樣直接使用
            
//         }
//     }

//     class Driver{
//         private IVehicle _vehicele;
//         // 建構子
//         public Driver(IVehicle vehicle){
//             _vehicele = vehicle;
//         }

//         public void Drive(){
//             _vehicele.Run();
//         }
//     }

//     interface IVehicle{
//         void Run();
//     }

//     interface IWeapon{
//         void Fire();
//     }

//     interface ITank:IVehicle, IWeapon{
//             new void Fire();
//             new void Run();
//         }

//     class Car:IVehicle{
//         public void Run(){
//             Console.WriteLine("Car is runing...");
//         }
//     }

//     class Truck:IVehicle{
//         public void Run(){
//             Console.WriteLine("truck is runnuing");
//         }
//     }

//     class LightTank:ITank{
//         public void Fire(){
//             Console.WriteLine("LightTank boom!");
//         }
//         public void Run(){
//             Console.WriteLine("LightTank kakaka!");
//         }
//     }
//     class MediumTank:ITank{
//         public void Fire(){
//             Console.WriteLine("MediumTank boom!");
//         }
//         public void Run(){
//             Console.WriteLine("MediumTank kakaka!");
//         }
//     }    
//     class HeavyTank:ITank{
//         public void Fire(){
//             Console.WriteLine("HeavyTank boom!");
//         }
//         public void Run(){
//             Console.WriteLine("HeavyTank kakaka!");
//         }
//     }
// }
