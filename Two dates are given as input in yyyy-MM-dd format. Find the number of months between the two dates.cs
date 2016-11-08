using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Date");
            string date1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Date");
            string date2 = Console.ReadLine();
            string y1 = string.Empty;
            string y2 = string.Empty;
            string d1 = string.Empty;
            string d2 = string.Empty;
            string m1 = string.Empty;
            string m2 = string.Empty;
            int i, j, k,L1,L2,c1=0,c2=0,yeardiff=0,m=0;
            int year1, year2, month1, month2,monthdiff=0,totalmonths=0,MONTH=12;
            L1 = date1.Length;
            L2 = date2.Length;
            for (i = 0; i < L1; i++)
            {
                if (date1[i] == '-')
                {
                    c1++;
                }
                else if (c1 == 1)
                {
                    m1 = m1 + date1[i];
                    
                }
                else if (c1 == 2)
                {
                    d1 = d1 + date1[i];
                }
                else
                {
                    y1 = y1 + date1[i];
                }

            }
            Console.WriteLine("Year 1={0}", y1);
            Console.WriteLine("Month 1={0}", m1);
            Console.WriteLine("Date 1={0}", d1);
            for (j = 0; j < L2; j++)
            {
                if (date2[j] == '-')
                {
                    c2++;
                }
                else if (c2 == 1)
                {
                    m2 = m2 + date2[j];
                }
                else if (c2 == 2)
                {
                    d2 = d2 + date2[j];
                }
                else
                {
                    y2 = y2 + date2[j];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Year 2={0}", y2);
            Console.WriteLine("Month 2={0}", m2);
            Console.WriteLine("Date 2={0}", d2);
            Console.WriteLine("\n");
            year1 = Convert.ToInt32(y1);
            year2 = Convert.ToInt32(y2);
            month1 = Convert.ToInt32(m1);
            month2 = Convert.ToInt32(m2);
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
                m++;
            }
            if (m != 0 || yeardiff != 0)
            {
                if (month1 > month2)
                {
                    monthdiff = month1 - month2;
                }
                else if (month2 > month1)
                {
                    monthdiff = month2 - month1;
                }
                else if (month1 == month2 && m != 0)
                {
                    Console.WriteLine("The given 2 dates are wrong .");
                    
                }

            }
            totalmonths = yeardiff * MONTH + monthdiff;
            Console.WriteLine("The total Months={0}", totalmonths);
            Console.ReadLine();
        }
    }
}
