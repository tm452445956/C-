using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_20作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter("zhangsan_1000_20");
            Fighter f2 = new Fighter("lisi_150_10");
            Console.WriteLine(Fighter.whowin(f1, f2));
            Console.ReadKey();
        }
    }
}
