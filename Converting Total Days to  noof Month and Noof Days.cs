using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_noofDays_to_DaysandMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of days:");
            int totaldays = Convert.ToInt16(Console.ReadLine());
            int noofMonth;
            int days;
            noofMonth = totaldays / 30;
            days = totaldays % 30;
            Console.WriteLine("the totaldays:{0} contains {1} Months and {2} Days", totaldays, noofMonth, days);
            Console.ReadLine();
        }
    }
}
