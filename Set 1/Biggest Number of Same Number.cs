using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biggest Number of Same Number:");
            int N, i,max=0,j;
            Console.WriteLine("Enter the Maximum Digits of the Number:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the Number:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        max = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = max;
                    }
                }

            }
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
