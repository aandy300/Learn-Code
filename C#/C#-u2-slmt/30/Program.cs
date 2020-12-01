// Interface 介面
using System;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player player1 = new Player("ming");
            Creature player2 = new Player("andy");
            
            Creature npc1 = new Npc("NPC");
            Creature monster1 = new Monster("monster");
            IAtk monster2 = new Monster("dpcs");
            
            player1.attack(monster1);
            // player1.attack(monster1); // 因生物沒 atk func() 不能使用
            Console.WriteLine(monster1.HP);

            monster2.attack(monster1);
            Console.WriteLine(monster1.HP);

            ITalks npc2 = new Npc("npc2");
            npc2.talk(player1);
            
        }
    }
}
