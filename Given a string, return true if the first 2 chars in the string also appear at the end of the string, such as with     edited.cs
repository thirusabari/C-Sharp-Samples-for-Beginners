using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            int L1 = b.Length;
            int i, j, count = 0;
            string start = string.Empty;
            string end = string.Empty;
            string e = string.Empty;
            for (i = 0; i < L1; i++)
            {
                start = start + b[i];
                count++;
                if (count == 2)
                {
                    break;
                }
            }
            count = 0;
            for (j = L1 - 1; j >= 0; j--)
            {
                end = end + b[j];
                count++;
                if (count == 2)
                {
                    break;
                }
            }
            char[] c = end.ToCharArray();
            int L3 = c.Length;
            int k;
            for (k = L3-1; k >= 0; k--)
            {
                e = e + c[k];
            }
            Console.WriteLine("\n");
            if (start ==e)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
