using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert new characters in a character array");
            int i, pos, N; char value;
            Console.WriteLine("enter the Maximum Range of Array");
            N = Convert.ToInt32(Console.ReadLine());
            char[] a = new char[N + 30];
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The values entered are");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Position to be inserted");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the character to be inserted");
            value = Convert.ToChar(Console.ReadLine());
            for (i = N; i >= pos; i--)
            {
                a[i] = a[i - 1];
            }
            N++;
            a[pos - 1] = value;
            Console.WriteLine("After the character inserted,the value changed as");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
