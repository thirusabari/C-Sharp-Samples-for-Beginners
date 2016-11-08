using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to  find the user input is Arithemtic Sequence or Not");
            int i, j, N, Count = 0, count = 0, temp, T = 0;
            Console.WriteLine("\n");
            Console.WriteLine("Enter the N Range of the Series");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] C = new int[N];
            C = a;
            Console.WriteLine("Enter the User Input Series");
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("The user input values are");
            for (j = 0; j < N; j++)
            {
                Console.Write("{0} ", C[j]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("To  find the Difference of the Series is");
            for (i = 0; i < N; i++)
            {

                for (j = i + 1; j < N; j++)
                {
                    temp = a[i] - a[j];
                    a[i] = temp;
                    T = temp;
                    break;
                }
            }
            Console.WriteLine("\n");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("To Find the User  Input is Arithmetic Sequence or Not");
            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == T)
                {
                    Count++;

                }
            }
            Console.WriteLine("\n");
            if ((Count == a.Length - 1))
            {
                Console.WriteLine("The Given Sequence is an Arithmetic Sequence ");
                for (i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > 0)
                    {

                        count++;
                    }
                }
                    if (count == a.Length - 1)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("The Given Sequence is in Ascending Order");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("The Given Sequence is in Descending Order");
                    }
                
            }
            else
            {
                Console.WriteLine("The Given Sequence is not an Arithemetic Sequence");
            }
            Console.ReadLine();
        }
    }
}
