using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class n2
    {
        public static void qiuzhishu()
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int s = 1 + a;
            int s1 = 0;
            for(int i =1;i<=a;i++)
            {
                if (a % i == 0)
                {
                    s1 += i;
                }
            }
            if (s1 == s)
                Console.WriteLine("是质数");
            else
                Console.WriteLine("不是质数");
        }
    }
}
