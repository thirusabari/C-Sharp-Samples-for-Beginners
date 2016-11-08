using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CloseFar");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range for the array");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int i, j=0,max=0,min=9999;
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The enetered values are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            int n = N - 1;
            int[] diff = new int[n];
            int d,k=0;
            for (i = N-1; i>=0; i--)
            {
                d = a[i] - a[i - 1];
                diff[k] = d;
                k++;
                if (k == 2)
                {
                    break;
                }
                d = 0;
            }
            for (k = 0; k < n; k++)
            {
                if (diff[k] > max)
                {
                    max = diff[k];
                }
                if (diff[k] < min)
                {
                    min = diff[k];
                }
            }
            if (min < max||max<min)
            {
                j++;
            }
            else if (min > max || min == max)
            {
                j = 0;
            }
            if (j == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            Console.ReadLine();
         
        }
    }
}
