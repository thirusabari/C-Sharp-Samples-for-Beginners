using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generation of Collatz Sequence");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());
            int n;
            n = N;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("{0} ", N);
                if (n % 2 == 0)
                {
                    collatz(N);
                    
                }
                else
                {
                    collatz1(N);
                    
                }
        
        }

        private static void Exit(int value)
        {
            Console.Write("{0} ", value/2);
            Console.ReadLine();
        }
       
        public static void collatz(int even)
        {
            
                int e = 0; e = even / 2;
                if (e != 1)
                {
            Console.Write("{0} ", e);
                if (e % 2 == 0)
                {
                    collatz(e);
                }
                else
                {
                    collatz1(e);
                    //return e;
                }
            }
            else
            {
                Exit(even);
            }
            
        }
        public static void collatz1(int odd)
        {
            
            int o=0,b=1,a,dummy=0;
            a = (odd * 3) + b;
            o = a;
            Console.Write("{0} ", o);
            if (o % 2 == 0)
            {
                collatz(o);
                //return o;
            }
            else
            {
                collatz1(o);
                //return o;
            }
            

        }
    }
}
