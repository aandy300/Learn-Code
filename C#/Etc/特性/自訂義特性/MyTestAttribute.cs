// 自訂特性 與 使用
// 特性class     
using System;

// #1 特性類一般以Attribute結尾 MyTestAttribute
// #2 需要繼承 System.Attribute
// #3 一般情況下聲明為 sealed 密封
// #4 一般情況下 特性類用來表示目標結構的一些狀態 (定義一些字段或者屬性，一般不定義方法)
[AttributeUsage(AttributeTargets.Class)] // 該特性 適用的範圍
sealed class MyTestAttribute:System.Attribute{
    public String Description{get;set;}
    public String VersionNumber{get;set;}
    public int ID{get;set;}
    public MyTestAttribute(string str){
        this.Description = str;
    }

}