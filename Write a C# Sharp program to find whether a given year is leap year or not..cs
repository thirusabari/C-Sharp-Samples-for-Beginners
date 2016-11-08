using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year want to be Checked");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("The given year {0} is an Leap Year", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The Given year is {0} not an Leap year", year);

            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("The given year is {0} Leap year", year);
            }
            else
                Console.WriteLine("The given year is not Leap Year");
            Console.WriteLine("Press any key to Quit");
            Console.ReadLine();
        }
    }
}
