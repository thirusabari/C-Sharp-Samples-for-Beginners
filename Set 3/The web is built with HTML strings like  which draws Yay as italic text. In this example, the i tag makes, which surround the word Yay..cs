using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            int count = 0, i, j, L1;
            string tagname = string.Empty;
            string word = string.Empty;
            char[] b = a.ToCharArray();
            L1 = b.Length;
            for (i = 0; i < L1; i++)
            {
                if ((int)b[i] == 34)
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    tagname = tagname + b[i];
                }
                else if (count == 3)
                {
                    word = word + b[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("<" + tagname + ">" + word + "<" + tagname + ">");
            Console.ReadLine();
        }
    }
}
