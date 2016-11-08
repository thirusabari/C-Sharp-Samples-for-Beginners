using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication193
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            Console.WriteLine("\n");
            int N = Convert.ToInt32(Console.ReadLine());
             Program p = new Program();
            p.fibonacci(N);
            Console.ReadLine();
        }

        
        public void fibonacci(int n)
        {
           
            int i, a = 0, b = 1,sum=0;
            for (i = 1; i <= n; i++)
            {
                sum = a + b;
                Console.Write("{0} ", a);
                a = b;
                b = sum;
                

            }
            Console.WriteLine("\n");
        }
    }
 

}
