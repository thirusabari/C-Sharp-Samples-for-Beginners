using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication195
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split Array");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range of the Array");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, j, sum = 0,max=0,pos=0;
            int[] a = new int[N];
            Console.WriteLine("Enter the input values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            if (N == 2)
            {
                for (i = 0; i < N; i++)
                {
                    for (j = i + 1; j < N; j++)
                    {
                        if (a[i] == a[j])
                        {
                            Console.WriteLine("Split array is possible");
                            Console.WriteLine("\n");
                            Console.WriteLine("true");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("false");
                            break;
                        }
                    }
                }
            }
            else
            {
                while (max == 0)
                {
                    for (i = 0; i < N; i++)
                    {
                        if (a[i] > max)
                        {
                            max = a[i];
                            pos = i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    for (i = 0; i < N; i++)
                    {
                        if (i == pos)
                        {
                            continue;
                        }
                        else
                        {
                            sum = sum + a[i];
                        }
                    }
                    if (sum == max)
                    {
                        Console.WriteLine("The split Array is possible");
                        Console.WriteLine("\n");
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
