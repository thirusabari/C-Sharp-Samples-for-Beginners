using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication119
{
    class Program
    {
        static void Main(string[] args)
        {
            int L1, L2, c1 = 0, c2 = 0;
            Console.WriteLine("Enter the First date:");
            string d1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Date:");
            string d2 = Console.ReadLine();
            char[] D1 = d1.ToCharArray();
            char[] D2 = d2.ToCharArray();
            L1 = D1.Length;
            L2 = D2.Length;
            int i, j, k, month1, month2, year1, year2, date1, date2, leap,datediff=0,yeardiff=0,monthdiff=0,totaldays=0;
            string m1 = string.Empty;
            string m2 = string.Empty;
            string dat1 = string.Empty;
            string dat2 = string.Empty;
            string y1 = string.Empty;
            string y2 = string.Empty;
            for (i = 0; i < L1; i++)
            {
                if (D1[i] == '/')
                {
                    c1++;
                }
                else if (c1 == 1)
                {
                    dat1 = dat1 + D1[i];
                }
                else if (c1 == 2)
                {
                    y1 = y1 + D1[i];
                }
                else if (c1 == 0)
                {
                    m1 = m1 + D1[i];
                }
            }
            for (j = 0; j < L2; j++)
            {
                if (D2[j] == '/')
                {
                    c2++;
                }
                else if (c2 == 1)
                {
                    dat2 = dat2 + D2[j];
                }
                else if (c2 == 2)
                {
                    y2 = y2 + D2[j];
                }
                else if (c2 == 0)
                {
                    m2 = m2 + D2[j];
                }
            }
            Console.WriteLine("\n");
            date1 = Convert.ToInt32(dat1);
            date2 = Convert.ToInt32(dat2);
            month1 = Convert.ToInt32(m1);
            month2 = Convert.ToInt32(m2);
            year1 = Convert.ToInt32(y1);
            year2 = Convert.ToInt32(y2);
            if (((year1 % 4 == 0 && year1 % 100 != 0) || year1 % 400 == 0) && (year2 % 4 == 0 && year2 % 100 != 0) || year2 % 400 == 0)
            {
                Console.WriteLine("The given year are leap year {0}  and {1} ", year1, year2);
                leap = 1;
            }
            else
            {
                leap = 1;
            }
            if (year1 > year2)
            {
                yeardiff = year1 - year2;
                
            }
            else if (year2 > year1)
            {
                yeardiff = year2 - year1;
            }
            else if (year1 == year2)
            {
                yeardiff = 0;
            }
            if (month1 > month2)
            {
                monthdiff = month1 - month2;
            }
            else if (month2 > month1)
            {
                monthdiff = month2 - month1;
            }
            else if (month1 == month2)
            {
                monthdiff = 0;
            }
            if (date1 > date2)
            {
                datediff = date1 - date2;
            }
            else if(date2>date1)
            {
                datediff = date2 - date1;
            }
            else if (date1 == date2)
            {
                datediff = 0;
            }
            totaldays = yeardiff * 365+monthdiff*31+datediff+leap;
            Console.WriteLine("The total days={0}", totaldays);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
