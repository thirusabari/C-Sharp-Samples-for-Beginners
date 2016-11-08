using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String30
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            char[] A;
            char[] B; int L1, L2, count = 0,i,j;
            Console.WriteLine("Program to Find the 2 strings are anagrams or not");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the First String:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the Second String:");
            b = Console.ReadLine();
            L1 = a.Length;
            L2 = b.Length;
            A = a.ToCharArray(0, L1);
            B = b.ToCharArray(0, L2);
            for (i = 0; i < L1; i++)
            {
                for (j = 0; j < L2; j++)
                {
                    if (A[i] == B[j])
                    {
                        count++;
                        
                    }

                }
                
            }
            if (count == L1 || count == L2)
            {
                Console.WriteLine("The string {0} and {1} are anagrams", a, b);


            }
            else
            {
                Console.WriteLine("The string {0} and {1} are not anagrams", a, b);
            }
              
            Console.ReadLine();


        }
    }
}
