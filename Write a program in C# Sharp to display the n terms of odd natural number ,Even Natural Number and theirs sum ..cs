using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Enter the N term Value");
            int N = Convert.ToInt32(Console.ReadLine());
            int c,c1;
            int sum = 0,sum1=0;
            Console.WriteLine(" the Odd Numbers are:");
            for (i = 1; i <= N; i++)
            {
                c = 2 * i - 1;
                Console.Write( c+" ");
                sum = sum + c;
            }
            
            Console.WriteLine("The sum of {0} odd Numbers is={1}", N, sum);
            Console.WriteLine("The even Numbers are:");
            for (j = 1; j <= N; j++)
            {
                c1 = 2*j;
                Console.Write(c1 + " ");
                sum1 = sum1 + c1;
            }
            Console.WriteLine("The sum of {0} odd Numbers is={1}", N, sum1);
            Console.ReadLine();
        }
    }
}
