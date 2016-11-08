using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swapping_of__two__numbers
{
    class Program
    {
         static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter the first number:");
              a = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The Values before swapping {0} {1}", a, b);
            if (a > 0 )
            {
                temp = a;
                a = b;
                b = temp;

                Console.WriteLine("The Values After Swapping {0} {1}", a, b);
            }
            Console.ReadLine();

        }
         
    }
}
