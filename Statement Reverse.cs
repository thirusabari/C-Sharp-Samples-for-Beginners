using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statement Reverse");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the String:");
            string s = Console.ReadLine();
            int i, r=0,L;
            char[] s1 = s.ToCharArray();
            L = s1.Length;
            string word = string.Empty;
            string[] revwords = new string[L];
            for (i = 0; i < L; i++)
            {
                if (s1[i] == ' ')
                {
                    revwords[r] = word;
                    r++;
                    word = string.Empty;
                    continue;
                }
                else
                {
                    word = word + s1[i];
                    if (i == L - 1)
                    {
                        revwords[r] = word;
                        r++;
                        word = string.Empty;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            int j = 0; j = r;
            for (r = j-1; r>=0; r--)
            {
                Console.Write("{0} ", revwords[r]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
