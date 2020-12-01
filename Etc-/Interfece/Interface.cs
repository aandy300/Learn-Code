// 接口继承

// 以下实例定义了两个接口 IMyInterface 和 IParentInterface。
// 如果一個接口繼承其他接口，那麼實現 class 或 結構 就需要實做所有接口的成員
// 以下 IMyInterface 繼承了 IParentInterface 接口，因此必須實做MethodToImplement()和ParentInterfaceMethod()

using System;

interface IParentInterface
{
    void ParentInterfaceMethod();
}

interface IMyInterface : IParentInterface
{
    void MethodToImplement();
}

class InterfaceImplementer : IMyInterface
{
    static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
        iImp.ParentInterfaceMethod();
    }

    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }

    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod() called.");
    }
}