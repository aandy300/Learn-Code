using System;
class Npc
{
    protected string Name;
    protected int Hp;

    public void talk(){
        Console.WriteLine("my name is : " + Name);    
    }
}