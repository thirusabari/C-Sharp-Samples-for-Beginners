using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of Given Number");
            int fact = 1,i;
            Console.WriteLine("Enter the Maximum Range");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of {0} given number is={1}", n, fact);
            Console.ReadLine();
        }
    }
}
