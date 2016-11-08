using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j,k;
            int sum = 0;
            int rem;
            int val;
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    int[] prime = { i };
                    foreach (int b in prime)
                    {
                        rem = i % 10;
                        val = i / 10;
                        sum = val + rem;
                        Console.WriteLine("The sum of digits of Prime number is:{0}={1}", i, sum);
                     }
                    int[] prime1 = { sum };
                    foreach (int c in prime1)
                    {
                        for (k = 2; k < c; k++)
                        {
                            if (c % k == 0)
                            {
                                break;
                            }
                        }
                        if (c == k)
                        {
                            Console.WriteLine("The Given Additive Prime  number is also an Prime number:{0}", c);
                            Console.WriteLine("\n");
                        }

                    }
            
                }
            }
                        
                
            
            
           Console.ReadKey();
               }
    }
}
 