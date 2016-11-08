using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the starting index position:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending index position");
            int end = Convert.ToInt32(Console.ReadLine());
            int i, L;
            string rev = string.Empty;
            char[] n = name.ToCharArray();
            L = n.Length;
            for (i = L - 1; i >= 0; i--)
            {
                rev = rev + n[i];
            }
            char[] r = rev.ToCharArray();
            Console.WriteLine("\n");
            for (i = start; i <end; i++)
            {
                Console.Write("{0}", r[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
