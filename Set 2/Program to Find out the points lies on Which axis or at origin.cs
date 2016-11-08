using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Program to find the given point is lies on which axis or origin");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x == 0 && y != 0)
            {
                Console.WriteLine("Points Lies on y-axis {0,1}", x, y);
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Points Lies on x-axis {0,1}", x, y);
            }
            else
                Console.WriteLine("The Points Lies at origin {0,1}", x, y);
            Console.ReadLine();
        }
    }
}
