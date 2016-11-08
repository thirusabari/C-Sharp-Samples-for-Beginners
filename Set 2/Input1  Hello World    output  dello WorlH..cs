using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the string:");
            string a = Console.ReadLine();
            char[] A = a.ToCharArray();
            int L, i, j,count=0,L1,L2;
            string word1 = string.Empty;
            string word2 = string.Empty;
            string sp = " ";
            string con = string.Empty;
            char temp = ' ';
            L = A.Length;
            for (i = 0; i < L; i++)
            {
                if (A[i] == ' ')
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    word2 = word2 + A[i];
                }
                else if (count == 0)
                {
                    word1 = word1 + A[i];
                }
            }
            char[] w1 = word1.ToCharArray();
            char[] w2 = word2.ToCharArray();
            L1 = w1.Length;
            L2 = w2.Length;
            for (i = 0; i < L1; i++)
            {
                for (j = 0; j < L2; j++)
                {
                    if (i == 0 && j == L2 - 1)
                    {
                        temp = w1[i];
                        w1[i] = w2[j];
                        w2[j] = temp;
                    }
                }
            }
            for (i = 0; i < L1; i++)
            {
                con = con + w1[i];
            }
            for (j = 0; j < L2; j++)
            {
                if (j == 0)
                {
                    con = con + sp + w2[j];
                }
                else
                {
                    con = con + w2[j];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("{0}", con);
            Console.ReadLine();

        }
    }
}
