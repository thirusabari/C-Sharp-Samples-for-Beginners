using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            int i, j, L;
            L = a.Length;
            string space = "-";
            string output = string.Empty;
            Console.WriteLine("\n");

            for (i = L - 1; i >=0; i--)
            {
                if (i == 0)
                {
                    output = output + a[i];
                    break;
                }
                output = output +a[i]+ space;    
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
