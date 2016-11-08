using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month");
            string month = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            int noofdays = 0;
            Console.WriteLine("\n");
            switch (month)
            {
                case "JANUARY":
                case "january":
                case "MARCH":
                case "march":
                case "MAY":
                case "may":
                case "JULY":
                case "july":
                case "AUGUST":
                case "august":
                case "OCTOBER":
                case "october":
                case "DECEMBER":
                case "december":
                    noofdays = 31;
                    Console.WriteLine("The number of days in {0} month is={1}", month, noofdays);
                    break;
                case "APRIL":
                case "april":
                case "JUNE":
                case "june":
                case "SEPTEMBER":
                case "september":
                case "NOVEMBER":
                case "november":
                    noofdays = 30;
                    Console.WriteLine("The number of days in {0} month is={1}", month, noofdays);
                    break;
                case "FEBRUARY":
                case "february":
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        noofdays = 29;
                        Console.WriteLine("The number of days in {0} month is={1}", month, noofdays);
                    }
                    else
                    {
                        noofdays = 28;
                        Console.WriteLine("The number of days in {0} month is={1}", month, noofdays);
                    }
                    break;
                default:
                    Console.WriteLine("you entered wrong year and month");
                    break;

            }
            Console.ReadLine();
        }
    }
}
