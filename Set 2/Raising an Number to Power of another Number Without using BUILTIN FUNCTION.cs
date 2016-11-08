using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i = 1;
            long power = 1;
            Console.WriteLine("Raising an Number to the Power of Another Number without Builtin Function");
            Console.WriteLine("Enter the Values of x and y:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            while (i <= y)
            {
                power = power * x;
                i++;
            }
            Console.WriteLine("The Power of {0} with {1} is={2}", x, y, power);
            Console.ReadLine();
        }
    }
}
