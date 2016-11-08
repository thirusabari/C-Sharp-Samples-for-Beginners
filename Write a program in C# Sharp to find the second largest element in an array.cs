using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N,j=0,max,second_max;
            Console.WriteLine("Enter the Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the Input from the user");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The input Elements Entered are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            max = a[0];
            
            Console.WriteLine("The Second Largest value is");
            for (i = 0; i < N; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    j = i;
                }

            }
                second_max = a[N - j - 1];
                for (i = 0; i < N; i++)
                {
                    if (second_max < a[i] && j != i)
                        second_max = a[i];
                }
                Console.WriteLine("The Second Largest Value in the array is={0}", second_max);
            
                Console.ReadLine();
        }
    }
}
