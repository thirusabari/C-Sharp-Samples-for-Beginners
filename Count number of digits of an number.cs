using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation of Number of Digits of an Given Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int remainder = 0, count = 0; string sum = string.Empty;
            string N = string.Empty;string f=string.Empty;
            N = n.ToString();
            while (n != 0)
            {
                remainder = n % 10;
                sum = sum + remainder;
                n = n / 10;
                count++;
            }
            for (int i = sum.Length-1; i >= 0; i--)
            {
                f = f + sum[i];
            }
            if (f== N)
            {
                Console.WriteLine("The number of digits in the given number is={0}", count);
            }
            Console.ReadLine();
        }
    }
}
