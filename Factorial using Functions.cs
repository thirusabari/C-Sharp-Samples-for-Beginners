using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication192
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive Factorial");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the number to be processed");
            int N = Convert.ToInt32(Console.ReadLine());
            int v=fact(N);
            Console.WriteLine("\n");
            Console.WriteLine("THe factorial of given number is:{0}", v);
            Console.ReadLine();
            
        }
        static public int fact(int n)
        {
            int i,val=1;
            if (n == 1)
                return n;
            else
            {
                for (i = n; i >0; i--)
                {
                    val = val * i;
                }
                
            }
            return val;
        }
    }
}
