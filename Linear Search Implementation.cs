using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N, key,pos,count=0;
            Console.WriteLine("Implementation of linear Search");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the N Value of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("\n");
            Console.WriteLine("Enter the input Elements of the array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            Console.WriteLine("The Input Array Contains Following Values:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the KeyValue to be Searched in the Array");
            key = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                if (a[i] == key)
                {
                    count++;
                    pos = i;
                    Console.WriteLine("The Element Found in the List");
                    Console.WriteLine("\n");
                    Console.WriteLine("The Element:{0} placed at {1} position in the list", key, pos);
                }
                else if(count==N)
                {
                    Console.WriteLine("The Element not found in the list");
                }
            }
            Console.ReadLine();

        }
    }
}
