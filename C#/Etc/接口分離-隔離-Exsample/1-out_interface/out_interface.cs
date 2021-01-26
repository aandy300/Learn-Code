// // 隱藏特定fuction

// using System;
// namespace IspExsample1{

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//             var dirver = new Driver(new Car());
//             dirver.Drive();
//             var c = new Car();
//             c.Run();
//             var x = new Driver(new HeavyTank());
//             dirver.Drive();
//             var S = new HeavyTank();
//             S.Fire();
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
//             void Fire();
//             void Run();
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
