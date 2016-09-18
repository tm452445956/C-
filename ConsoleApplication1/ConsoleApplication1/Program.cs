using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class ReadString
    {
        public static void Main()
        {
            write();
            Console.ReadKey();
        }
        static void write()
        {
            int a;
            Console.WriteLine("输入第一个数");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数");
            int num2 = Convert.ToInt32(Console.ReadLine());
            a = num1 + num2;
            Console.WriteLine("结果是 " + a);
        }
        static int addnum(int a, int b)
        {
            return a + b;
        }   
    }
}
