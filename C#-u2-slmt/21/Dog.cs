using System;

class Dog : Monster
{
    private new int Hp;
    // 3. 想要呼叫基底類別的建構子時 
    // 2種 一種直接塞給base.name 一種產生物件時塞
    // public Dog() : base("dog1")
    public Dog(string name) : base(name)
    {
        Hp = 500;
        // 1. 衍生類別 有 同名屬性時 呼叫"基底類別"的屬性
        base.Hp = 10000;
    }

    public string say(){
        return info() + " i am dog";
    }

    public void gethp(){
        Console.WriteLine(" base.hp:{0} | HP: {1}", base.Hp , Hp );
    }

    // 2. 要使用override掉的  "原本class部分func()內容"時
    public override string info(){
        return base.info() + " in dog";
    }
}