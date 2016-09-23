using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_21作业
{
    class FunctionFactory
    {
        public static Func<int[], int[]> factory(int n)
        {
            return x =>
            {
                int[] arr1 = new int[x.Length];                                                                                                                                                                  
                for (int i = 0; i < x.Length; i++)
                {
                    arr1[i] = x[i] * n;
                }
                    return arr1;
            };
            // return  x=> {xxxxxxxxxxxx return yyyyyy;};
            
        }
    }
}
