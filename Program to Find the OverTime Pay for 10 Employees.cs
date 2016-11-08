using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, overpay,hour;
            while (i <= 10)
            {
                hour = Convert.ToInt32(Console.ReadLine());
                if (hour >= 40)
                {
                    overpay = (hour - 40) * 12;
                    Console.WriteLine("The Employees worked {0} hours and the overtime pay is={1}", hour, overpay);

                }
                else
                {
                    Console.WriteLine("The Employees worked {0} hour is less than the maximum hours 40", hour);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
