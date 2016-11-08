using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication181
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maximum Range of the Array:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] div = new int[N];
            int[] num = new int[N];
            int[] quo = new int[N];
            int d = 0, n = 0, q = 0;
            Console.WriteLine("\n");
            Console.WriteLine("Enter the numbers:");
            for (n = 0; n < N; n++)
            {
                num[n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Divident values:");
            for (d = 0; d < N; d++)
            {
                div[d] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (d = 0; d < N; d++)
            {
                for (n = 0; n < N; n++)
                {
                    if (d == n)
                    {
                        quo[q] = (num[n] / div[d]);
                        q++;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Quotient values are:");
            for (q = 0; q < N; q++)
            {
                Console.Write("{0} ", quo[q]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("d      n    output");
            for (d = 0; d < N; d++)
            {
                for (n = 0; n < N; n++)
                {
                    for (q = 0; q < N; q++)
                    {
                        if ((d == n)&&(n == q)&&(q==d))
                        {
                            if ((quo[d] * div[d]) == num[n])
                            {
                                Console.WriteLine("{0}      {1}    truthy", div[d], num[n]);
                            }
                            else
                            {
                                Console.WriteLine("{0}      {1}    False ",div[d],num[n]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
