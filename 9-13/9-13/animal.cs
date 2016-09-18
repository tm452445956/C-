using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13
{
    class Animal
    {
        public virtual void Walk ()
        {
            Console.WriteLine("正在走路");
        }
        public virtual void Cry()
        {
            Console.WriteLine("正在叫");
        }
    }
}
