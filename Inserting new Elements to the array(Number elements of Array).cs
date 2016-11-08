using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert an new element into the array");
            int i, j, pos, value, N;
            Console.WriteLine("Enter the Maximum Range of the series");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N+15];
            Console.WriteLine("Enter the Values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input elements entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Position to be inserted");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the value to be inserted");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (i = N; i >= pos; i--)
            {
                a[i] = a[i - 1];
            }
            N++;
            a[pos - 1] = value;
            Console.WriteLine("After the New element inserted,the values are changed as");
            for (i = 0; i <N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
