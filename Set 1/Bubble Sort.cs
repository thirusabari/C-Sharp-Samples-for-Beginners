using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,temp;
            Console.WriteLine("Implementation on Bubble Sort");
            Console.WriteLine("Enter the N Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the input Elements of the Array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the input elments are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After the Bubble sort");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.ReadLine();
        }
    }
}
