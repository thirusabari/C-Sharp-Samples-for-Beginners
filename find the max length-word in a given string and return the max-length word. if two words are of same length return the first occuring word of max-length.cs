using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            int i, l=0, L,count=0,maxlen=0,c1=0,s=0,j=0;
            L = a.Length;
            string sum = string.Empty;
            string[] words = new string[40];
            int[] len = new int[20];

            for (i = 0; i < L; i++)
            {
                if (a[i] == ' ')
                {
                    count++;
                    continue;
                }
                else if (count == 1 || count == 2 || count == 3 || count == 4)
                {
                    sum = string.Empty;
                }
                else
                {
                    sum = sum + a[i];
                    words[j] = sum;
                    j++;
                    s++;
                    len[l] = sum.Length;
                    l++;
                    c1++;
                }

            }
            for (l = 0; l <c1; l++)
            {
                if (len[l] > maxlen)
                {
                    maxlen = len[l];
                }
            }
            Console.WriteLine("\n");
            for (j = 0; j < s; j++)
            {
                if (maxlen == words[j].Length)
                {
                    Console.WriteLine("{0}(Length-{1})", words[j], maxlen);
                }
            }

            Console.ReadLine();
        }
    }
}
