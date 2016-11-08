using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication191
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrores Increasing");
            Console.WriteLine("\n");
            int i, j, count = 0, N;
            Console.WriteLine("Enter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int diff = 0, eq = 0,c1=0;
            Console.WriteLine("Enter the input values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                c1 = 0; eq = 0; diff = 0;
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        eq++;
                    }
                    if (a[i] < a[j])
                    {
                        diff++;
                    }
                    if (eq != 0 ||diff != 0)
                    {
                        c1++;
                        
                        break;
                    }
                    else
                    {
                        c1--; 
                        break;
                    }
                }
                count = count + c1;

            }
            Console.WriteLine("\n");
            if (count == N - 1)
            {
                Console.WriteLine("true   " + count);
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
