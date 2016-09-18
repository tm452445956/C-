using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中秋昨夜
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Good(new int[] { 1, 3, 5, 7 }, 5));
            Console.ReadKey();
        }
        public static bool Good(int[] arg, int x)
        {
            int s = 0;
            foreach (int i in arg)
            {
                s += i;
            }
            float s1 = s * 1.0f / arg.Length;
            return x > s1;
        }
    }
}
