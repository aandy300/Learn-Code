using System;
class Player {
 
    private int countGold; // 擁有的金子數目，每個金子值 50
    private int countSilver; // 擁有的銀子數目，每個銀子值 25
    private int countCopper; // 擁有的銅的數目，每個銅值 10
 
    // TODO: 欠缺計算總值的程式碼
    public int TotalG{
        get{ return this.countCopper * 10 + this.countSilver * 25 + this.countGold * 50 ;}
    }
    // 飢餓度，必須介於 0~100 之間
    private int hungerRate; 
    
    // TODO: 欠缺存取飢餓度(hungerRate) 的程式碼
    public int HungerRate{
        get { return hungerRate ;}
        set {
           hungerRate = value;
           if(hungerRate >= 100){
               hungerRate = 100;
           }else if (hungerRate <= 0){
               hungerRate = 0;
           }
        }
    }
 
    public Player() {
        this.countGold = 0;
        this.countSilver = 0;
        this.countCopper = 0;
        this.hungerRate = 20;
    }
 
    public void pickAGold() {
        countGold++;
    }
 
    public void pickASilver() {
        countSilver++;
    }
 
    public void pickACopper() {
        countCopper++;
    }
}