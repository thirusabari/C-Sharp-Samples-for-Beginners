using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication84
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array to Find the Subarray");
            int i, j, N,sum=0,n,count=0;
            Console.WriteLine("ENter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            j = 0;
            n = N;
            while (j <= n)
            {
                count++;
                for (i = j; i <= n-1;i++)
                {
                    sum = sum + a[i];
                }
                if (sum == 0)
                {
                    Console.WriteLine("The subArray found at starting index of {0} position and {1} position", j, n-1);
                    j = j + 1;
                    n = n - 1;
                    continue;
                    
                }
                else
                {
                    j = j + 1;
                    n = n - 1;
                    sum = 0;
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
