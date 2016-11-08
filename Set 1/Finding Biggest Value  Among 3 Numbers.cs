using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_of__3__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values:");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("The  a is  greatest value than  b and c ={0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The b is the  greatest value than c and a={0}", b);
            }
            else
            {
                Console.WriteLine("The c is the greatest value than b and a={0}", c);
            }
            Console.ReadLine();
        }
    }
}
