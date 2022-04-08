using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication91
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the string");
            int num = Convert.ToInt32(Console.ReadLine());
            int n, rem, sum = 0;
            n = num;
            while (n != 0)
            {
                rem = n % 10;
                if(rem %2 == 1)
                {
                    sum = sum + rem;
                }
                n = n / 10;
            }
            Console.WriteLine("The sum Value={0}", sum);

            if (sum%2 == 0)
            {
                Console.WriteLine("even", sum);

            }
            else
            {
                Console.WriteLine("odd");
            }

            Console.ReadLine();
        }
    }
}
