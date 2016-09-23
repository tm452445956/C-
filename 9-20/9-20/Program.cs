using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((char)'a');
            Console.WriteLine((char)('a' - 32));
            Console.WriteLine(ZebulansNightmare("camel_case"));
            Console.ReadKey();
        }
        public static string ZebulansNightmare(string functionName)
        {
            string n = "_";
            string s = "";
            for(int i=0;i<functionName.Length;i++)
            {
                int j = n.IndexOf(functionName[i]);
                if (j == -1)
                    s += functionName[i];
                else
                {
                    s += (char)(functionName[i + 1] - 32);
                    i++;
                }
            }
            return s;
        }
    }
}
