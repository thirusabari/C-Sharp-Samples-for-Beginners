using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to check if the three ponits are fall on straight line or not");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the other three points");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int slope1, slope2;
            slope1 = (y2 - y1) / (x2 - x1);
            slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
            {
                Console.WriteLine("The Three points are Fall on Straight Line");
            }
            else
            {
                Console.WriteLine("The Three points are not fall on Straight Line");
            }
            Console.ReadLine();
        }
    }
}
