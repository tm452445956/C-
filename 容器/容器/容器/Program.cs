using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 容器
{
    class Program
    {
        static void Main(string[] args)
        {
            //队列 
            QueueTest();
            
            //List 升级的数组
            ListTest();
            //Map(字典)
            HashTest();
            //栈
            StackTest();
            Console.ReadKey();
        }

        private static void QueueTest()
        {
            Queue<int> queue = new Queue<int>();//建一个空队列
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(5);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

        }
        //Stack 栈
        static void StackTest() 
        {
            Stack<char> stack = new Stack<char>();//创建一个空栈
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }

        //List
        public static void ListTest()
        {
            List<int> list1 = new List<int>();//创建空数组
            List<int> list2 = new List<int>(new int[] { 1, 2, 3 });//根据现有的数组创建
            list1.Add('c');//增
            list1.Add('c');
            list1.Add(12);
            list1.Add(11);
            list1.AddRange(new int[] { 4, 5, 6 }); //加一片
            list1.Remove(99);//删第一个遇到的相等的元素
            list1.RemoveAt(0);//删下标
            list1.RemoveAll(x => x % 3 == 0);//通过条件删
            list1[0] = 33;//改
            Console.WriteLine(list1[0]);//查
            list1.Find(x => x % 3 == 0);
            list1.FindLast(x => x % 3 == 0);
            list1.FindAll(x => x % 3 == 0);
            list1.FindIndex(x => x % 3 == 0);
            int i = list1.FindLastIndex(x => x % 3 == 0);

        }

        public static void HashTest()
        {
            Dictionary<int, Student> stutable = new Dictionary<int, Student>();//创建空字典
            stutable.Add(1, new Student("zhangsan", 90, 180, 60));//增 
            stutable.Add(2, new Student("wanger", 90, 183, 60));//增 
            stutable.Remove(1);//删
            stutable[1] = new Student("lisi", 50, 170, 70);//改
            stutable[1].name = "wangwu";
            Console.WriteLine(stutable[1]);//查

        }

        public static Dictionary<int, char> constructDic(List<int> arr, string str)
        {
            //arr.Count
            //null
            return null;
        }
        //移除栈内的偶数  得到一个全是奇数的栈
        public static Stack<int> RemoveOdd(Stack<int> stack) 
        {
            return null;
        }
        // 移除队列里的质数  得到一个非质数组成的队列
        public static Queue<int> RemovePrime(Queue<int> stack) 
        {
            return null;
        }
        //1,2,3,4,5    abcde


        //1:'a'  4:'b'  3:'c'  16:'d' 5:'e'
    }

    class Student
    {
        public string name;
        public int record;
        public int height;
        public int weight;
        public Student(string name, int record, int h, int w)
        {
            this.name = name;
            this.record = record;
            this.weight = w;
            this.height = h;
        }
    }
}
