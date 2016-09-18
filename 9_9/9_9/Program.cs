using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            作业 A = new 作业(2,4);
            Console.WriteLine(A.Area());
            Console.WriteLine("长={0}",A["h"]);
            Console.WriteLine("宽={0}",A["w"]);
            float a=A["h"];
            float b=A["w"];
            A.Flip(ref a,ref b);
            Console.WriteLine("长={0}",a);
            Console.WriteLine("宽={0}", b);
            Console.ReadKey();
        }
    }
}
        