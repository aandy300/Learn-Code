using System;
class Player : Creature, IAtk, ITalks
{

    private int power = 10;
    public Player(string name) : base(name)
    {

    }
    public void talk(Creature target){
        Console.WriteLine("hi"+ target.NAME + "i am" + this.NAME);    
    }

    public void attack(Creature target){
        target.injured(power);
    }
}