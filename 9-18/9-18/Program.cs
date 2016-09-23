using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = { new int[] { 0, 0, 0, 0, 0 }, 
                            new int[] { 0, 0, 0, 1, 0 }, 
                            new int[] { 0, 1, 1, 0, 1 }, 
                            new int[] { 0, 0, 1, 0, 1 }, 
                            new int[] { 0, 1, 1, 0, 1 } };

            Console.WriteLine(CountSide(arr, 2, 1));
            Console.WriteLine(ToDec("2FG3"));
            Console.ReadKey();
        }
        public static int CountSide(int[][] arr, int x, int y)
        {
            int s=0;
            for(int i=-1;i<=1;i++)
            {
                for(int j=-1;j<=1;j++)
                {
                    if(i!=0||j!=0)
                    {
                        try
                        {
                            if (arr[x + i][y + j] == 1)
                                s++;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            continue;
                        }
                    }
                }
            }
            return s;
        }
        public static int ToDec(string n)
        {
            Dictionary<char,int> dict=new Dictionary<char,int>();
            string x=new string(n.Reverse().ToArray());
            int[] arr=new int[n.Length];
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                switch (x[i])
                {
                    case '1': arr[i] = 1; break;
                    case '2': arr[i] = 2; break;
                    case '3': arr[i] = 3; break;
                    case '4': arr[i] = 4; break;
                    case '5': arr[i] = 5; break;
                    case '6': arr[i] = 6; break;
                    case '7': arr[i] = 7; break;
                    case '8': arr[i] = 8; break;
                    case '9': arr[i] = 9; break;
                    case '0': arr[i] = 0; break;
                    case 'a': arr[i] = 10; break;
                    case 'b': arr[i] = 11; break;
                    case 'c': arr[i] = 12; break;
                    case 'd': arr[i] = 13; break;
                    case 'e': arr[i] = 14; break;
                    case 'f': arr[i] = 15; break;
                }
                count+=arr[i]*(int)Math.Pow(16,i);
            }
            return count;
        }

   }
}