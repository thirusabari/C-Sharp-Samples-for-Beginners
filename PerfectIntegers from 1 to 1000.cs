using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int i, j, sum = 0; 
                for (i = 1; i <= n; i++)
                {

                    sum = 0;
                    for (j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sum = sum + j;

                        }
                    }
                        if (sum == i)
                        {
                            Console.WriteLine(" the number {0} is an Perfect Integer {1}", n, sum);
                        }
                    
                }
              Console.ReadLine();
        }
    }
}
