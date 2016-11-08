using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N, t;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] Descending = new int[N];
            Console.WriteLine("Enter the input elements of the Array");
            for (i = 0; i < N; i++)
            {
                Descending[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Values intered in that array is");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(Descending[i]);
            }
            Console.WriteLine("Sorting of Given Array in Descending Order");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (Descending[i] < Descending[j])
                    {
                        t = Descending[i];
                        Descending[i] = Descending[j];
                        Descending[j] = t;
                    }

                }
            }
            Console.WriteLine("The Sorted Array Values is");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(Descending[i]);
            }
            Console.ReadLine();
        }
    }
}
