using System;
class Npc : Creature, ITalks
{
    public Npc(string name) : base(name)
    {

    }
    public void talk(Creature target){
        Console.WriteLine("hi, "+ target.NAME + " i am " + this.NAME);    
    }
}