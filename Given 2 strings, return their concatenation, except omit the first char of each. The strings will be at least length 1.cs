using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication151
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First string");
            string a = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the second string:");
            string b = Console.ReadLine();
            char[] x = a.ToCharArray();
            char[] y = b.ToCharArray();
            int L1, L2;
            L1 = x.Length;
            L2 = y.Length;
            string nonstart = string.Empty;
            int i, j,count=0;
            for (i = 0; i < L1; i++)
            {

                if (count == 0)
                {
                    count++;
                    continue;
                }
                else
                {
                    nonstart = nonstart + x[i];
                }
                
            }
            count = 0;
            for (j = 0; j < L2; j++)
            {
                if (count == 0)
                {
                    count++;
                    continue;
                }
                else
                {
                    nonstart = nonstart + y[j];
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine(nonstart);
            Console.ReadLine();
        }
    }
}
