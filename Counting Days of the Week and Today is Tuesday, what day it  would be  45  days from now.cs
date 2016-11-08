using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting Days of the Week");
            Console.WriteLine("Enter the day and its number too");
            string Today =Console.ReadLine();
            int day_val = Convert.ToInt32(Console.ReadLine());
            int week, noof_days,day=0,Exact_day=0;
            week = day_val / 7;
            noof_days = day_val % 7;
            switch (Today)
            {
                
                case "SUNDAY":
                case "sunday":
                    day = 1;
                    break;
                case "MONDAY":
                case "monday":
                    day = 2;
                    break;
                case "TUESDAY":
                case "tuesday":
                    day = 3;
                    break;
                case "WEDNESDAY":
                case "wednesday":
                    day = 4;
                    break;
                case "THURSDAY":
                case "thursday":
                    day = 5;
                    break;
                case "FRIDAY":
                case "friday":
                    day = 6;
                    break;
                case "SATURDAY":
                case "saturday":
                    day =7;
                    break;
                    
                    
            }
            Exact_day = day + noof_days;
              

                Console.WriteLine("Number of weeks={0} and the number of days={1}", week, noof_days);
                
                switch (Exact_day)
                {
                    case 0:
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    default:
                        Console.WriteLine("nothing");
                        break;
                }
               
            
            Console.ReadLine();
        }
    }
}
