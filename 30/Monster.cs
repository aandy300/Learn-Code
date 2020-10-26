using System;
class Monster : Creature, IAtk
{
    protected int power = 10;

    public Monster(string name) : base(name)
    {

    }
    public void attack(Creature target){
        target.injured(power);
    }
}