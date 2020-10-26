using System;
abstract class Creature
{
    protected string Name;
    protected int Hp;
    public Creature(string name){
        Hp = 100;
        Name = name;
    }

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
    public string NAME
    {
        get{return Name; }
    }
    public void injured(int dmg){
        Hp -= dmg;    
    }
}