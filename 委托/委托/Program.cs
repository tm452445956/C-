using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 5, 8, 13 };
            Array.ForEach(Map(arr,chen), x => Console.WriteLine(x));
            Console.ReadKey();

        }
        public delegate int Operate(int x);
        public static int[] Map(int[] arr, Operate op)
        {
            int[] newarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = op(arr[i]);
            }
            return newarr;
        }
        static int chen(int x)
        {
            return x * x;
        }
    }
}
