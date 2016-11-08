using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotient_and_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find Quotient and Remainer without using division(/) operator");
            int d = Convert.ToInt32(Console.ReadLine());
            int div = Convert.ToInt32(Console.ReadLine());
            int i, j, diff=0,Quotient;
            if (d > div)
            {
                diff = d - div;
            }
            else if (div > d)
            {
                diff = div - d;
            }
            for (i = 1; i < diff; i++)
            {
                Quotient = div * i;
                for (j = 0; j < div; j++)
                {
                                      
                    if ((Quotient + j) == d)
                    {
                        Console.WriteLine("The Given number {0} has Quotient {1} and Remainer={2}", d, i, j);
                        break;
                    }
                    else if ((Quotient == d) && (j==0)) 
                    {
                        Console.WriteLine("The Given number {0} has Quotient {1} and Remainer={2}", d, i, j);
                        break;
                    }
                }
            }
            Console.ReadLine();


        }
    }
}
