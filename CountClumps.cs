using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication190
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountClumps");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range for the input array:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int i, j, count = 0;
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("THe array contains following values:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        i++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            int diff = 0, count1 = 0;
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        diff = a[i] - a[j];
                        if (diff == 0)
                        {
                            count1++;
                
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\n");
            if (count1==N-1)
            {
                Console.WriteLine(a[0]);
            }
            else
            {
                Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
