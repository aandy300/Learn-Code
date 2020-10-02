using System;

    class Basedata
    {
        private int Hp;
        public string Name;

        public int GetHpInfo{
            get{return Hp;}
        }

        public string GetNameInfo{
            get{return Name;}
        }

        public virtual string Atk(Basedata target){
            return Name + " hit-> " + target.Name;
        }
    }