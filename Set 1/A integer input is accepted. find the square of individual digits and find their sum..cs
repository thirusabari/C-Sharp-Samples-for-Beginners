using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication106
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            int num = Convert.ToInt32(Console.ReadLine());
            int n, rem,sum=0;
            n = num;
            while (n != 0)
            {
                rem = n % 10;
                sum = sum + rem * rem;
                n = n / 10;
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum Value={0}", sum);
            Console.ReadLine();
        }
    }
}
