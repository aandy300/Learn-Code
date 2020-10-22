using System;
class Monster
{
    protected string Name;
    protected int Hp;
    protected int power = 10;

    public void talk(){
        Console.WriteLine("my name is : " + Name);    
    }

    public void atk(Villager target){
        target.injured(power);
    }
}