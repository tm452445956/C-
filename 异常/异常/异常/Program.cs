using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常?  运行时出现，出现了错误的数据访问   
            //报错?  编译时出现，语法错误 
            //最常见的异常  数组越界
            int[] arr = { 1, 2, 3, 4, 5 };
            Object o = null;
            //try catch finally 处理异常
            try
            {
                Console.WriteLine("异常之前");
                arr[7] = 3;
                //throw new MyException();
                Console.WriteLine(o.ToString());
                Console.WriteLine("异常之后");
            }
            catch (MyException me) 
            {
                Console.WriteLine(me.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("越界啦 {0}", e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("空引用了 {0}", e.Message);
            }
            finally 
            {
                Console.WriteLine("不管是否发生异常都会执行");
            }
            Console.ReadKey();
           //IndexOutOfRangeException
        }
    }

    class MyException : Exception 
    {
        public override string Message
        {
            get
            {
                return "我的异常";
            }
        }
    }
}
