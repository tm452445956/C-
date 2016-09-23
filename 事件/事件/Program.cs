using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Mouse m = new Mouse();
            Bird b = new Bird();
            cat.actions += m.mouseup;
            cat.actions += b.birdup;
            cat.Walk("二楼");
            Console.ReadKey();
        }
    }
}
