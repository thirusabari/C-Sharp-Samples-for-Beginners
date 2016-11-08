using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Value of Range of Series");
            int i, j,k, N, max=0, min=100000, Range;
            Console.WriteLine("Enter the Maximum value of the Series");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            b = a;
            Console.WriteLine("Enter the Values");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Values Entered Are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("To Find The Maximum Value of Series");
           
            for (i = 0; i < N; i++)
            {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                    if (a[i]<min)
                    {
                        min = a[i];
                    }
            }
            Console.WriteLine("Maximum Value={0}", max);
            Console.WriteLine("Minimum Value={0}", min);
            Range = max - min;
            Console.WriteLine("The Range of the Series is={0}", Range);        
            Console.ReadLine();
        }
    }
}
