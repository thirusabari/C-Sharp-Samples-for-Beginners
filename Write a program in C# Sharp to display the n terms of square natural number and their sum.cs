using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a,i,sum=0;
            Console.WriteLine("The sum of n natural Numbers:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The squared Natural Numbers are");
            for (i = 1; i <= n; i++)
            {
                a = i * i;
                Console.Write("{0} ", a);
                sum = sum + a;
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum of {0}  Squared numbers is={1}", n, sum); 
            Console.ReadLine();
        }
    }
}
