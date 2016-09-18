using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class nn
    {
        public static void print9()
        {
            int i = 5;
            Console.WriteLine(i.ToString());
            int bint = Convert.ToInt32("1001", 2);//2进制换10进制；
            Console.WriteLine("2进制{0}", bint);
            string xs=Convert.ToString(3098, 16);//10进制换16进制。
            Console.WriteLine("10进制换16进制{0}", xs);
            int bi = Convert.ToInt32(Console.ReadLine(), 2);
            string ci = Convert.ToString(bi, 16);
            Console.WriteLine("输入的2进制换为16进制为{0}", ci);
        }
    }
}
