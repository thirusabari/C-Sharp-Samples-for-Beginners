using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,count=0;
            Console.WriteLine("Enter the Maximum length of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        
                    }
                }
            }
            Console.WriteLine("The Duplicate elements found in array is={0}", count);
            Console.ReadLine();
        }
    }
}
