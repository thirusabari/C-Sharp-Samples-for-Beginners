using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConversion36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Concatenation without using builtin functions");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = string.Empty;
            int i, j, L1, L2;
            L1 = a.Length;
            L2 = b.Length;
            for (i = 0; i < L1; i++)
            {
                c = c + a[i];
            }
            for (j = 0; j < L2; j++)
            {
                c = c + b[j];
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
