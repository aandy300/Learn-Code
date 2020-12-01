using System;

class Worker : Person
{
    public override void Talk(){
       Console.WriteLine("my name: {0}", base.name);
    }

}