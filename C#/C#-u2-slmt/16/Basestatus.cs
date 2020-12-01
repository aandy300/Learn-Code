using System;

class Basestatus
{
    private int Hp = 100;
    private string Name;

    public int Hpinfo{
        get{ return Hp ;}
    }

    public string Nameinfo{
        get{ return Name ;}
    }

    public void Hert(int c){
        Hp -= c;
    }

    // public Basestatus(int hp, string s){
    //     Hp = hp;
    //     Name = s;
    // }
    
}