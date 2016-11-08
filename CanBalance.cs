using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication180
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maximum Range for the array:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] a = new int[N];
            Console.WriteLine("Enter the values:");
            int i, j,sum1=0,sum2=0;
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("The values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N / 2; i++)
            {
                sum1 = sum1 + a[i];
            }
            for (j = N / 2; j < N; j++)
            {
                sum2 = sum2 + a[j];
            }
            Console.WriteLine("\n");
            if (sum1 == sum2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
