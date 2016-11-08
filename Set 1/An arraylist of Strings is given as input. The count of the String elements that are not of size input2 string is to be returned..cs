using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication117
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count = 0,N,len=0;
            Console.WriteLine("Enter the Maximum Length of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            string c = string.Empty;
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the second string:");
            string b = Console.ReadLine();
            for (i = 0; i < N; i++)
            {
                if (b == a[i]&&b.Length==a[i].Length)
                {
                    len = a[i].Length;
                    c = a[i];
                    continue;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine("\n");
            if (count != 0 && len != 0 && c.Length!= 0)
            {
                Console.WriteLine("{0}({1} Length:{2})", count, c, len);

            }
            Console.ReadLine();
        }
    }
}
