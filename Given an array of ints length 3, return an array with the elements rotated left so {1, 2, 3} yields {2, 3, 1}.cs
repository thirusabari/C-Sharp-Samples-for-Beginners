using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication156
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N,b=0,c=0,d=0;
            Console.WriteLine("Enter the Maximum Length of the array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int n;
            if (N == 3)
            {
                Console.WriteLine("Enter the values:");
                Console.WriteLine("\n");
                for (i = 0; i < N; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    b = a[i];
                }
                else if (i == 1)
                {
                    c = a[i];
                }
                else
                {
                    d = a[i];
                }
            }
            int[] rot = new int[3] { c, d, b };
            n = rot.Length;
            Console.WriteLine("\n");
            Console.WriteLine("The rotated elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", rot[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
