using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Find the Root of Quadratic Equation");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double x1, x2, d;
            d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                Console.WriteLine("Both Roots Are Equal");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine("The First Root={0}", x1);
                Console.WriteLine("The Second Root={1}", x2);

            }
            else if (d > 0)
            {
                Console.WriteLine("Both Roots are Real and differential");
                x1 = -b + Math.Sqrt(d) / (2.0 * a);
                x2 = -b - Math.Sqrt(d) / (2.0 * a);
                Console.WriteLine("2 Real Roots are:");
                Console.WriteLine("The First Root={0}", x1);
                Console.WriteLine("The Second Root is={0}", x2);

            }
            else
                Console.WriteLine("The Given roots are Imaginary");
            Console.ReadLine();

        }
    }
}
