using System;
class Monster
{
    protected string Name;
    protected int Hp;
    protected int power = 10;

    public void talk(){
        Console.WriteLine("my name is : " + Name);    
    }
    // 多形性
    public void atk(Creature target){
        target.injured(power);
    }
}