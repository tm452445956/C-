using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 取数组的奇数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Sum(new int[]{1,2,3,4,5,6}));
            Console.ReadKey();
        }
        static int geteven(int[] arr)
        {
            int a=0;
            int i=0;
            while(i<arr.Length)
            {
                if (arr[i] % 2 == 1)
                {
                    a += 1;
                }
                i++;
            }
            return a;
        }
        static int Sum(int[] a)
        {
            int s = 0;
            foreach (int i in a)
            {
                if(i%3==0)
                s ++;
            }
            return s;
        }
    }
}
