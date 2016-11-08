using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication134
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0, l=0, m=0, N;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            int[] sum = new int[N];
            int[] minus = new int[N];
            int[] mul = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the First Array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Second Array");
            for (j = 0; j < N; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Choice");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '+':
                    
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            if (i==j)
                            {
                                sum[k] = a[i] + b[j];
                                k++;
                            }
                            
                        }
                    }
                    Console.WriteLine("\n");
                    for (k = 0; k < N; k++)
                    {
                        Console.Write("{0} ", sum[k]);
                    }
                    Console.WriteLine("\n");
                    break;
                case '-':
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            if (i == j)
                            {
                                minus[l] = a[i] - b[j];
                                l++;
                            }
                        }
                    }
                    for (l = 0; l < N; l++)
                    {
                        Console.Write("{0} ", minus[l]);
                    }
                    Console.WriteLine("\n");
                    break;
                case '*':
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            if (i == j)
                            {
                                mul[m] = a[i] * a[j];
                                m++;
                            }
                        }
                    }
                    for (m = 0; m < N; m++)
                    {
                        Console.Write("{0} ", mul[m]);
                    }
                    Console.WriteLine("\n");
                    break;
            }

            Console.ReadLine();
        }
    }
}
