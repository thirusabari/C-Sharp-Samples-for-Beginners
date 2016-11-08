using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication118
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,ask;
            Console.WriteLine("Enter the Maximum Length of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input array elements:");
            int[] a = new int[N];
            int[] b = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ask the number to remove:");
            ask = Convert.ToInt32(Console.ReadLine());
            List<int> a1 = new List<int>(a);
            foreach(int a2 in a)
            {
                
                if (ask == a2)
                {
                    a1.Remove(a2);
                }
                
            }
            Console.WriteLine("\n");
            foreach (int a3 in a1)
            {
                Console.Write("{0} ", a3);
            }
            Console.WriteLine("\n");
            
            Console.ReadLine();

        }
    }
}
