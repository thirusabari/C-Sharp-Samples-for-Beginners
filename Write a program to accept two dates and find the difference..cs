using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First date:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second date:");
            string b = Console.ReadLine();
            int i, j, L1, L2, c1 = 0, c2 = 0;
            int con1 = 0, con2 = 0, con3 = 0, con4 = 0, con5 = 0, con6 = 0, con7 = 0, con8 = 0;
            char[] x = a.ToCharArray();
            char[] y = b.ToCharArray();
            L1 = x.Length;
            L2 = y.Length;
            int date1, date2, datediff=0;
            int month1, month2, monthdiff=0;
            int year1, year2, yeardiff=0;
            string d1 = string.Empty;
            string d2 = string.Empty;
            string m1 = string.Empty;
            string m2 = string.Empty;
            string y1 = string.Empty;
            string y2 = string.Empty;
            for (i = 0; i < L1; i++)
            {
                if (x[i] == '/'||x[i]=='-')
                {
                    c1++;
                    continue;
                }
                else if (c1 == 1)
                {
                    d1 = d1 + x[i];
                }
                else if (c1 == 2)
                {
                    y1 = y1 + x[i];
                }
                else if (c1 == 0)
                {
                    m1 = m1 + x[i];
                }
            }
            for (j = 0; j < L2; j++)
            {
                if (y[j] == '/'||y[j]=='-')
                {
                    c2++;
                    continue;
                }
                else if (c2 == 1)
                {
                    d2 = d2 + y[j];
                }
                else if (c2 == 2)
                {
                    y2 = y2 + y[j];
                }
                else if (c2 == 0)
                {
                    m2 = m2 + y[j];
                }
            }
            Console.WriteLine("\n");
            date1 = Convert.ToInt32(d1);
            date2 = Convert.ToInt32(d2);
            month1 = Convert.ToInt32(m1);
            month2 = Convert.ToInt32(m2);
            year1 = Convert.ToInt32(y1);
            year2 = Convert.ToInt32(y2);
            if (year1 >= 1900 && year1 <= 9999)
            {
                if (month1 >= 1 && month1 <= 12)
                {
                    if (date1 <= 31 && (month1 == 1 || month1 == 3 || month1 == 5 || month1 == 7 || month1 == 8 || month1 == 10 || month1 == 12))
                    {
                        con1++;
                    }
                    else if (date1 <= 30 && (month1 == 4 || month1 == 6 || month1 == 9 || month1 == 11))
                    {
                        con2++;
                    }
                    else if (date1 <= 28 && month1 == 2)
                    {
                        con3++;
                    }
                    else if (date1 <= 29 && ((year1 % 4 == 0 && year1 % 100 != 0) || year1 % 400 == 0))
                    {
                        con4++;
                    }
                    else
                    {
                        Console.WriteLine("Date1 is invalid");
                       
                    }
                }
                else
                {
                    Console.WriteLine("Month is invalid");

                }
            }
            else
            {
                Console.WriteLine("Year is invalid");
            }
            if (con1 != 0 || con2 != 0 || con3 != 0 || con4 != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("The first date is  valid date:");
            }
            else
            {
                Environment.Exit(0);
            }
            if (year2 >= 1900 && year2 <= 9999)
            {
                if (month2 >= 1 && month2 <= 12)
                {
                    if(date2<=31&&(month2==1||month2==3||month2==5||month2==7||month2==8||month2==10||month2==12))
                    {
                        con5++;
                    }
                    else if(date2<=30&&(month2==4||month2==6||month2==9||month2==11))
                    {
                        con6++;
                    }
                    else if (date2 <= 28 && month2 == 2)
                    {
                        con7++;
                    }
                    else if(date2<=29&&((year2%4==0&&year2%100!=0)||year2%400==0))
                    {
                        con8++;
                    }
                    else
                    {
                        Console.WriteLine("The date 2 is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("The Month2 is invalid");
                }
            }
            else
            {
                Console.WriteLine("The Year2 is invalid");
            }
            if(con5!=0||con6!=0||con7!=0||con8!=0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("The  second date is valid");
            }
            else
            {
                Environment.Exit(0);
            }
            if(year1>year2)
            {
                yeardiff=year1-year2;
            }
            else if(year2>year1)
            {
                yeardiff=year2-year1;
            }
            else if(year1==year2)
            {
                yeardiff=0;
            }
            if(month1>month2)
            {
                monthdiff=month1-month2;
            }
            else if(month2>month1)
            {
                monthdiff=month2-month1;
            }
            else if(month1==month2)
            {
                monthdiff=0;
            }
            if(date1>date2)
            {
                datediff=date1-date2;
            }
            else if(date2>date1)
            {
                datediff=date2-date1;
            }
            else if(date1==date2)
            {
                datediff=0;
            }
            Console.WriteLine("\n");
            Console.WriteLine("The diference between two dates is:");
            Console.WriteLine("\n");
            Console.WriteLine("{0} Years {1} Months and {2} Days",yeardiff,monthdiff,datediff);
            Console.ReadLine();
        }
    }
}
