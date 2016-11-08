using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove an Character in a character array");
            int i, j, N, pos;
            Console.WriteLine("Enter the Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            char[] a = new char[N];
            Console.WriteLine("Enter the Values");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The input Values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the position to be deleted");
            pos = Convert.ToInt32(Console.ReadLine());
            while (pos < N)
            {
                a[pos - 1] = a[pos];
                pos++;
            }
            N--;
            Console.WriteLine("After the values removed,the output characters are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
