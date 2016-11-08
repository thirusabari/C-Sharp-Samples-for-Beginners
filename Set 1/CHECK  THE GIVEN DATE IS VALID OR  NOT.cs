using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string d = Console.ReadLine();
            int count = 0, year = 0, month = 0, date = 0,i,L,condition1=0,condition2=0,condition3=0,condition4=0;
            string y = string.Empty;
            string m = string.Empty;
            string dat = string.Empty;
            char[] D = d.ToCharArray();
            L = D.Length;
            for (i = 0; i < L; i++)
            {
                if (D[i] == '/'||D[i]=='-')
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    dat = dat + D[i];
                }
                else if (count == 2)
                {
                    y = y + D[i];
                }
                else if (count == 0)
                {
                    m = m + D[i];
                }
            }
            Console.WriteLine("\n");
            year = Convert.ToInt32(y);
            date = Convert.ToInt32(dat);
            month = Convert.ToInt32(m);
            if (year >= 1900 && year <= 9999)
            {
                if (month >= 1 && month <= 12)
                {
                    if (date <= 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                    {
                        condition1++;
                    }
                    else if (date <= 30 && (month == 4 || month == 6 || month == 9 || month == 11))
                    {
                        condition2++;
                    }
                    else if ((date >= 1 && date <= 28) && month == 2)
                    {
                        condition3++;
                    }
                    else if (((date >= 1 && date <= 29) && month == 2) && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
                    {
                        condition4++;
                    }
                    else
                    {
                        Console.WriteLine("Date is Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Month is Invalid");
                }
            }
            else
            {
                Console.WriteLine("Year is Invalid");
            }
            if (condition1 != 0 || condition2 != 0 || condition3 != 0 || condition4 != 0)
            {
                Console.WriteLine("The Given Date is an Valid Date");
                Console.WriteLine("\n");
                Console.WriteLine(d);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
