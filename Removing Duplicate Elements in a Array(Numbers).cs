using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Removing Duplicate Elements in Array");
            int i, j, k,N,count=0;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Elements entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i+1; j <N ; )
                {
                    if (a[j] == a[i])
                    {
                        for (k = j; k < N-1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        N--;
                    }
                    else
                    {
                        j++;
                        
                    }
                }
                
            }
            Console.WriteLine("After the Duplicates value removed, the array elements are:");
            for (i = 0; i <N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
