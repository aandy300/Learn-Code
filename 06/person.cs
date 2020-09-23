using System;

namespace _06
{
    class Person
    {
        // 屬性
        public string firstname;
        public string lastname;
        public int age;

        // 建構子 和 多載 結構子沒有回傳
        public Person(string f_name, string l_name){
            firstname = f_name;
            lastname = l_name;
            age = 99;    
        }
        public Person(string f_name, string l_name, int age_count){
            firstname = f_name;
            lastname = l_name;
            age = age_count;
        }
        

        // 功能(func method)
        // public = 公開可用 string = 回傳的型別 Info = method名稱 ( = input型別與容器名稱)
        public string Info()
        {
            return "Name:" + firstname + " " + lastname + "\nAge:" + age;
        }

        public string Talk(Person p){
            return firstname + " " + lastname + "對" + p.firstname + " " + p.lastname + " say: hi" ;
        }

        // 沒有要回傳東西時使用 void
        public void Addage(){
            age++;
        }
    }
}
