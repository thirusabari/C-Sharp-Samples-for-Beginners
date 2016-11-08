using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String36
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,i,j,frequency=0,count=0,L;
            Console.WriteLine("Finding of First Occurrance of an String:");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Input Elements of the Array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();

            }
            Console.WriteLine("\n");
            Console.WriteLine("The Array Contains Following Values");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0}, ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("TO Find the Length of the Each String");
            for (i = 0; i < N; i++)
            {
                
                    L = a[i].Length;
                    count++;
                    Console.WriteLine("The string={0} and length={1}", a[i], L);

                    if (L == 1)
                    {
                        frequency = L;
                        Console.WriteLine("\n");
                        Console.WriteLine("The String {0} placed at {1}th position with length={2}", a[i], count, L);
                        break;
                    }
                
            }
            
            Console.ReadLine();
        }
    }
}
