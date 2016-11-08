using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication150
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array of Elements");
            int N, i, j,k=0,m=0,max=0,min=9999,count=0;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range of the array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the elements to be processed");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            Console.WriteLine("The input elements are");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (a[j] == a[i])
                    {
                        b[k] = j;
                        k++;
                        b[k] = i;
                        k++;
                        m++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("The index positions are:");
            for (k = 0; k <= m; k++)
            {
                Console.Write("{0} ", b[k]);
            }
            Console.WriteLine("\n");
            for (k = 0; k <= m; k++)
            {
                if (b[k] > max)
                {
                    max = b[k];
                }
            }
            for (k = 0; k <= m; k++)
            {
                if (b[k] < min)
                {
                    min = b[k];
                }
            }
            for (i = 0; i < N; i++)
            {
                if (i == min)
                {
                    count++;
                }
                else if (i == max)
                {
                    count++;
                    break;
                }
                else if (count >= 1)
                {
                    count++;
                }
            }
            Console.WriteLine("The number of elements between the duplicate elements are:{0}", count);
            Console.ReadLine();
        }
    }
}
