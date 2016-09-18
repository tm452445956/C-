using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Bathroom a = new Bathroom(10,8,5);
            a.Bath();
            a.Volume();
            Console.ReadKey();
        }
    }
}
