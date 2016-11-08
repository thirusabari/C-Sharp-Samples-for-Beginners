using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, a, b,c,d,LCM;
            Console.WriteLine("Finding Highest Common Factor of 2 Numbers:");
            Console.WriteLine("Enter the First Number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                a = n1 % n2;
                b = n2 % a;
                while (b == 0)
                {
                    Console.WriteLine("The Highest Common Factor of {0},{1} numbers is={2}", n1, n2, a);
                    break;
                }
                if (a > 0)
                {
                    LCM = (n1 * n2) / a;
                    Console.WriteLine("THe LCM  value of {0},{1} is ={2}", n1, n2, LCM);
                }
            }
            else
            {
                c = n2 % n1;
                d = n1 % c;
                while (d == 0)
                {
                    Console.WriteLine("The Highest Common Factor of {0},{1} numbers is={2}", n1, n2, c);
                    break;
                }
                if (c > 0)
                {
                    LCM = (n1 * n2) / c;
                    Console.WriteLine("THe LCM  value of {0},{1} is ={2}", n1, n2, LCM);
                }
            }
            
            Console.ReadLine();
        }
    }
}
