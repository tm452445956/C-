using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_21作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> fives = FunctionFactory.factory(5);    // returns a function - fives
            int[] myArray = new int[] {1,2,3};
            int[] res = fives(myArray);
            Array.ForEach(res, x => Console.WriteLine(x));
            Console.ReadKey();
        }


    }
}
