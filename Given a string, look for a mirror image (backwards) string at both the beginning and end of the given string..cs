using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication170
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string n = Console.ReadLine();
            char[] a = n.ToCharArray();
            int L, i, j;
            string word = string.Empty;
            L = a.Length;
            for (i = 0; i < L/2; i++)
            {
               
                for (j = L-1; j>=L/2; j--)
                {
                    if (a[i] == a[j])
                    {
                        word = word + a[i];
                        break;
                    }
                    
                }
            }
            Console.WriteLine("\n");
            if (L == 3 && word != string.Empty)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
