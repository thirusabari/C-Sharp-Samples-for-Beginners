using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date:");
            string date = Console.ReadLine();
            int i,L,count=0,year,leap=0,N=0,C=0,dat,day=0;
            string d = string.Empty;
            string m = string.Empty;
            string y = string.Empty;
            L = date.Length;
            for (i = 0; i < L; i++)
            {
                if (date[i] == '-')
                {
                    count++;
                }
                else if (count == 1)
                {
                    d = d + date[i];
                }
                else if (count == 2)
                {
                    y = y + date[i];
                }
                else
                {
                    m = m + date[i];
                }
            }
            Console.WriteLine("The given month,date and year ");
            Console.WriteLine(m);
            Console.WriteLine(d);
            Console.WriteLine(y);
            year = Convert.ToInt32(y);
            dat = Convert.ToInt32(d);
            Console.WriteLine("\n");
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("The given year is an Leap year={0}", year);
                leap++;
            }
            else
            {
                Console.WriteLine("The given year is not an leap year={0}", year);

            }
            switch (m)
            {
                case "01":
                case "1":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C = 0;
                        }
                        
                        
                    }
                    break;
                case "2":
                case "02":
                    
                    if (leap == 0)
                    {
                        N = 28;
                    }
                    else if (leap > 0)
                    {
                        N = 29;
                    }
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C = 0;
                        }
                        
                    }
                    break;
                case "3":
                case "03":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C = 0;

                        }
                        
                    }
                    break;
                case "4":
                case "04":
                    N = 30;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                           
                            C = 0;
                        }
                        
                    }
                    break;
                case "5":
                case "05":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                          
                            C = 0;
                        }
                        
                    }
                    break;
                case "6":
                case "06":
                    N = 30;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C = 0;
                        }
                        }
                    break;
                case "7":
                case "07":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C=0;
                        }
                        
                    }
                    break;
                case "8":
                case "08":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }

                        }
                        
                    }
                    break;
                case "9":
                case "09":
                    N = 30;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            
                            C = 0;
                        }
                        
                    }
                    break;
                case "10":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {

                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C ==7 )
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            C = 0;
                           

                        }
                        
                        
                    }
                    break;
                case "11":
                    N = 30;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            C = 0;

                        }
                        
                    }
                    break;
                case "12":
                    N = 31;
                    for (i = 1; i <= N; i++)
                    {
                        C++;
                        if (i == N)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (dat == i)
                        {
                            day = C;
                            C = 0;
                            break;
                        }
                        if (C == 7)
                        {
                            if (dat == i)
                            {
                                day = C;
                                C = 0;
                                break;
                            }
                            C = 0;
                        }
                        
                    }
                    break;
            
            }
            switch (day)
            {
                case 7:
                    Console.WriteLine("\n");
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("\n");
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("\n");
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("\n");
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("\n");
                    Console.WriteLine("Wendesday");
                    break;
                case 5:
                    Console.WriteLine("\n");
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("\n");
                    Console.WriteLine("Friday");
                    break;
            }
            Console.ReadLine();
        }
    }
}
