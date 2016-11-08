using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, diff,sum,N;
            Console.WriteLine("Find the Sum of Nth Term of Arithmetic Progression Series");
            Console.WriteLine("Enter the first Number of the Series");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the nth Term of the Series");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Difference Between the Series");
            diff = Convert.ToInt32(Console.ReadLine());
            N=n-1;
            sum=(n/2)*((2*a)+(N*diff));
            Console.WriteLine("The sum of {0} term of A.P Series is={1}", n, sum);
            Console.ReadLine();

        }
    }
}
