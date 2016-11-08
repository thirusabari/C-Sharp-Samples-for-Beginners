using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_no_of_digits_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int a,b, count = 0;
            b = n;
            while (b != 0)
            {
                a = b % 10;
                count = count + 1;
                b = b/ 10;
            }
            Console.WriteLine("the number {0} contains = {1} digits", n, count);
            Console.ReadLine();
        }
    }
}
