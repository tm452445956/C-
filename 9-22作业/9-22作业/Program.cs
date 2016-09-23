using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_22作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();//创建一个空栈
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            RemoveOdd(stack);
            Queue<int> queue = new Queue<int>();
            for (int i = 2; i < 20; i++)
            {
                queue.Enqueue(i);
            }
            RemovePrime(queue);
        }
        //移除栈内的偶数  得到一个全是奇数的栈
        public static Stack<int> RemoveOdd(Stack<int> stack)
        {
            int x = stack.Count;
            Stack<int> stacknew = new Stack<int>();
            for (int i = 0; i < x; i++)
            {
                if (stack.Peek() % 2 == 1)
                    stacknew.Push(stack.Pop());
                else
                    stack.Pop();
            }
            Stack<int> stacknew2 = new Stack<int>();
            int y = stacknew.Count;
            for (int i = 0; i < y; i++)
            {
                stacknew2.Push(stacknew.Pop());
            }
            return stacknew2;
        }
        // 移除队列里的质数  得到一个非质数组成的队列
        public static Queue<int> RemovePrime(Queue<int> queue)
        {
            int x = queue.Count;
            Queue<int> queuenew = new Queue<int>();
            for (int i = 0; i < x; i++)
            {
                if (qzs(queue.Peek()))
                    queuenew.Enqueue(queue.Dequeue());
                else
                    queue.Dequeue();
            }
            return queuenew;
        }
        public static bool qzs(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return true;
            }
            return false;
        }
    }
}
