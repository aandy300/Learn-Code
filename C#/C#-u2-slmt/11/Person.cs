using System;

namespace _11
{
    class Person
    {
        // 屬性
        public string firstname;
        public string lastname;
        public int age;        
        public static int pass_age = 30;
        public static bool pass_age_anser;

        private string school;
        
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
            return "\nName:" + firstname + " " + lastname + "\tAge:" + age;
        }

        public string Talk(Person p){
            return firstname + " " + lastname + "對" + p.firstname + " " + p.lastname + " say: hi" ;
        }

        // 沒有要回傳東西時使用 void
        public void Addage(){
            age++;
        }
        
        // 在func() 前面增加static 可以直接使用 不用產生新物件在使用
        public static int addmath(int a_int, int b_int){
            int c;
            c = a_int + b_int;
            return c;
        }

        public static bool checkage(int a){
            if(a > pass_age){
                pass_age_anser = false;               
            }else{
                pass_age_anser = true;               
            }         
            return pass_age_anser;
        }
    }
}
