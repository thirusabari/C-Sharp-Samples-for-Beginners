using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,t;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] Ascending = new int[N];
            Console.WriteLine("Enter the input elements of the Array");
            for (i = 0; i < N; i++)
            {
                Ascending[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Values intered in that array is");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(Ascending[i]);
            }
            Console.WriteLine("Sorting of Given Array in Ascending Order");
            for (i = 0; i < N; i++)
            {
                for(j = i + 1; j < N; j++)
                {
                    if (Ascending[i] > Ascending[j])
                    {
                        t = Ascending[i];
                        Ascending[i] = Ascending[j];
                        Ascending[j] = t;
                    }

                }
            }
            Console.WriteLine("The Sorted Array Values is");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(Ascending[i]);
            }
            Console.ReadLine();
        }
    }
}
