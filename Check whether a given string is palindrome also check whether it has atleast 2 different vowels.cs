using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string A = Console.ReadLine();
            int I, L,p=0,a=0,e=0,i=0,o=0,u=0,v=0;
            L = A.Length;
            string pal = string.Empty;
            for (I = L - 1; I >= 0; I--)
            {
                pal = pal + A[I];
            }
            if (A == pal)
            {
                p++;
            }
            for (I = 0; I < L; I++)
            {
                if (A[I] == 'a')
                {
                    a++;   
                }
                else if(A[I]=='e')
                {
                    e++;
                }
                else if (A[I] == 'i')
                {
                    i++;
                }
                else if (A[I] == 'o')
                {
                    o++;
                }
                else if (A[I] == 'u')
                {
                    u++;
                }
            }
            Console.WriteLine("\n");
            if (p != 0 && (a!=0&&e!=0)||(a!=0&&i!=0)||(a!=0&&o!=0)||(a!=0&&u!=0)||(e!=0&&i!=0)||(e!=0&&o!=0)||(e!=0&&u!=0)||(i!=0&&o!=0)||(i!=0&&u!=0)||(o!=0&&u!=0))
            {
                Console.WriteLine("The given string is an palindrome {0}={1}", A, pal);
                Console.WriteLine("\n");
                Console.WriteLine("2 vowels found in the given string");
                Console.WriteLine("\n");
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
                Console.WriteLine("\n");
                Console.WriteLine("2 vowels not found");
            }

            Console.ReadLine();

        }
    }
}
