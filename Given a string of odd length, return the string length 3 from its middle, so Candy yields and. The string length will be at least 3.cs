using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication157
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            int n = 3, i, diff = 0, count = 0,c=0;
            int L;
            char[] b = a.ToCharArray();
            L = b.Length;
            if (L == n)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine(a);
                
               
               
            }
             if (L > n)
            {
                diff = L - n;
            }
            count = diff / 2;
            L=L-count;
            
            if (count != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("The middle 3 elements are:");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                for (i = count; i < L; i++)
                {
                    Console.Write("{0}", b[i]);
                    c++;
                    if (c == 3)
                        break;
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
