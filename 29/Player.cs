using System;
// 繼承性 class, 建構子
class Player : Creature
{

    public Player(string name) : base(name)
    {

    }
    public override void talk(){
        Console.WriteLine("haha my name is : " + Name);    
    }
}