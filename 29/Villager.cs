using System;
class Villager
{
    protected string Name;
    protected int Hp;
    public Villager(string name){
        Hp = 100;
        Name = name;
    }
    // 封裝性
    public int HP
    {
        get{ return Hp; }
        set{ 
                if(value >= Hp){
                    Hp = 0;
                }else{
                    Hp -= value;
                }
            }
    }
    public virtual void talk(){
        Console.WriteLine("my name is : " + Name);    
    }
}