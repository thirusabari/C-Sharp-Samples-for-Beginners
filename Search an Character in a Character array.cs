using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Searching an Character in a Character array");
            int i, index, N;
            char search;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            char[] a = new char[N];
            Console.WriteLine("enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the element to be searched");
            Console.WriteLine("\n");
            search = Convert.ToChar(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                if (search == a[i])
                {
                    index = i;
                    Console.WriteLine("The searched element {0} found at {1} position", search, index);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
