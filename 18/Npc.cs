using System;

    class Npc : Basedata
{
    public  Npc(string name){
        this.Name =  name;
    }

    public override string Atk(Basedata target){
        return "Npc can't atk!";
    }

    public string move(){
        return "MOVE";
    }
}