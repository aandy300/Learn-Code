using System;

class Monster
{
    protected int Hp = 100;

    public int HP{
        get{ return Hp;}
    }

    protected string info(){
        return "i am monster";
    }
}