// case 
// enum 列舉 類似 go iota

using System;

class Monster
{
    private int X;
    private int Y;

    public String ReportPostion(){
        return "now postion: " + X + "," + Y;
    }
    
    public void Move(Direction direction){
        switch (direction)
        {      
            case Direction.UP:
                Y +=1;
                break;
            case Direction.DOWN:
                Y -=1;
                break;
            case Direction.LEFT:
                Y -=1;
                break;
            case Direction.RIGHT:
                Y +=1;
                break;
        }
        
    }


    // if else 上1下2左3右4
    // public void Move(int direction){
    //     if(direction == 1){
    //         Y += 1;
    //     }else if(direction == 2){
    //         Y -= 1;
    //     }else if(direction == 3){
    //         X -= 1;
    //     }else if(direction == 4){
    //         X += 1;
    //     }   
    // }
}