using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            Console.WriteLine("\n");
            char[] b = a.ToCharArray();
            int L = b.Length;
            int i, j,c=2;
            for (i = 0; i < L; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(b[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
