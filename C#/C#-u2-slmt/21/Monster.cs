using System;

class Monster
{
    private string name;
    protected int Hp = 100;
    protected string Monsterinfo = "info: monster";

    public Monster(String name)
    {
        this.name =  name;
    }

    public string HP{
        get{ return  Hp + " " + name;}
    }

    public virtual string info(){
        return "i am monster";
    }
}