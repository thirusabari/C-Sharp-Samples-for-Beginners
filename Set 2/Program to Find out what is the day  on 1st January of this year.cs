using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the January 1st day of the Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            int normaldays, leapdays,totaldays,firstday;
            normaldays = (Year - 1) * 365;
            leapdays = (Year - 1) / 4 - (Year - 1) / 100 + (Year - 1) / 400;
            totaldays = normaldays + leapdays;
            firstday = totaldays % 7;
            switch (firstday)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                 case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
            }
            Console.ReadLine();

        }
    }
}
