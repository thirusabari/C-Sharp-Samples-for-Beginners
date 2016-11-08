using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping19
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 9, i, sum = 0,n;
            Console.WriteLine("Enter the N Number of Terms:");
            n = Convert.ToInt32(Console.ReadLine());
            int T = t;
            for (i = 1; i <= n; i++)
            {
                sum = sum + t;
                Console.Write("{0}+", t);
                t = t* 10+T;
            }
            Console.WriteLine("The sum value is={0}", sum);

            Console.ReadLine();
        }
    }
}
