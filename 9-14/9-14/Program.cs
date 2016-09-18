using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello();
            //Hello("田萌");
            //animal ani = new Dog();
            //ani.Cry();
            IShape tri = new Triangle(2,4);
            IShape cir = new Circle(5);
            Console.WriteLine("{0}的面积是{1}",tri.name,tri.Area());
            Console.WriteLine("{0}的面积是{1}",cir.name,cir.Area());
            Console.ReadKey();
        }
        static void Hello() 
        {
            Console.WriteLine("你好");
        }
        static void Hello(string name)
        {
            Console.WriteLine("你好{0}", name);
        }
    }
}
