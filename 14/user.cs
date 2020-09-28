using System;

namespace _13
{
    class User
    {
        private string Username;
        private string Password;
        private int hp;
    
        public User (string u_name, string pw, int shp){
            Username = u_name;
            Password = pw;
            hp = shp;   
        }

        public int HP
        {
            get{ return hp; }
            set{
                if (hp <= value){
                    hp = 0;
                }else{
                    hp -= value;
                }
            }
        }

        // 防止扣到負數
        public void hit(int c){
            if (hp >= c){
                this.hp -= c;
            }else{
                hp = 0;
            }
        }

        public int get_hpstaus(){
            return hp;
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



        private void reset(){
            Password = "";
        }
    }
}