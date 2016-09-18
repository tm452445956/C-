using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an= new Animal();
            an.Walk();
            Animal an2 = new Human();
            an2.Walk();
            Animal cat = new cat();
            cat.Cry();
            Animal dog = new dog();
            dog.Cry();
            Console.ReadKey();
        }
    }
}
