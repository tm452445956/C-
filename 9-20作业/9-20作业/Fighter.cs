using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_20作业
{
    class Fighter
    {
        public string name;
        public int hp;
        public int attack;
        public Fighter(string values)
        {
            string[] arr=values.Split('_');
            this.name = arr[0];
            this.hp = Convert.ToInt32(arr[1]);

            this.attack = Convert.ToInt32(arr[2]);
        }
        public static string whowin(Fighter f1, Fighter f2)
        {
            do
            {
                f1.hp-=f2.attack;
                f2.hp-=f1.attack;

            }while(f1.hp>0&&f2.hp>0);
            if (f1.hp == 0)
                return f2.name;
            else
                return f1.name;
        }
    }
}
