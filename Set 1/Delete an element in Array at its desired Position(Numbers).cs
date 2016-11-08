using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Removing an Element in Array with index position");
            int i, j, k, N,pos;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the input Elements of the Array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Elements are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Position of the element to be removed");
            pos = Convert.ToInt32(Console.ReadLine());
            while (pos < N)
            {
                a[pos - 1] = a[pos];
                pos++;
            }
            N--;
            Console.WriteLine("After the element removed values are:");
            for (i = 0; i < N; i++)
           {
               
                   Console.Write("{0} ", a[i]);
               
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
