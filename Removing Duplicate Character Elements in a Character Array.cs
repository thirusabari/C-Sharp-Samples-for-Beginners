using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Duplicate Elements in a Character Array:");
            int i, j, k, N;
            Console.WriteLine("Enter the N Elements of the character array:");
            N = Convert.ToInt32(Console.ReadLine());
            char[] a = new char[N];
            Console.WriteLine("Enter the elements of the array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The input Elemets entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; )
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
            Console.WriteLine("After duplicate characters Removed,filtered values are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
