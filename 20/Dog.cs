using System;

class Dog : Monster
{
    public Dog(){
        Hp = 500;
    }

    public string say(){
        return info() + " i am dog";
    }
}