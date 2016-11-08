using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capitalization");
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            int i, L,count=0;
            L = a.Length;
            for (i = 0; i < L; i++)
            {
                if (a[i] == ' ')
                {
                    count++;
                    continue;
                }
                else if (count == 2)
                {
                    count++;
                    a[i] = (char)(a[i] - 32);
                }
                else if (count == 0)
                {
                    count++;
                    a[i] = (char)(a[i] - 32);
                }
            }
            Console.WriteLine("\n");
            for (i = 0; i < L; i++)
            {
                Console.Write("{0}", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
