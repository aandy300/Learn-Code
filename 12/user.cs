using System;

namespace _12
{
    class User
    {
        private string Username;
        private string Password;
        private int Hp;
    
        public User (string u_name, string pw, int hp){
            Username = u_name;
            Password = pw;
            Hp = hp;
        }

        // 防止扣到負數
        public void hit(int c){
            if (Hp >= c){
                this.Hp -= c;
            }else{
                Hp = 0;
            }
        }

        public bool compaerPassword (User p){
            if (Password == p.Password){
                return true;
            }else{
                return false;
            }
        }

        public string get_username(){
            return Username;
        }

        public int get_hpstaus(){
            return Hp;
        }

        private void reset(){
            Password = "";
        }
    }
}