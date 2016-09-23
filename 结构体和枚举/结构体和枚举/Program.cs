using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体和枚举
{
    class Program
    {   
        enum CharCode
        {
            char_1=49,
            char_2=50,
            char_3=51

        }
        static void Main(string[] args)
        {
            Point p = new Point(3,4);
            Console.WriteLine("点到原点的距离{0}", p.Distance());
            write();
            Console.ReadKey();
        }
        static void write()
        {
            Console.WriteLine("输入一个值");
            CharCode c=(CharCode)Console.Read();
            switch (c)
            {
                case CharCode.char_1: Console.WriteLine("你好"); break;
                case CharCode.char_2:Console.WriteLine("我好");break;
                case CharCode.char_3: Console.WriteLine("大家好"); break;
            }
        }
    }
    struct Point 
    {
        public int x;
        public int y;//强制要求在构造函数里声明参数。
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

}
