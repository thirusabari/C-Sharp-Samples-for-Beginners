using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program to check that given number is  a valid ISBN(International Standard Book Number) or not");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number");
            int N = 10, L, i, j,n,sum=0,ISBN;
            n = N;
            int[] b = new int[N];
            string s = string.Empty;
            for (i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
                s = s + b[i];
            }
            L = b.Length;
            
                for (i = 0; i < L; i++)
                {
                    j = b[i] * n;
                    sum = sum + j;
                    n--;
                }
                ISBN = sum % 11;
                Console.WriteLine("\n");
                Console.WriteLine("The sum value ={0}", sum);
                if (ISBN == 0)
                {
                    Console.WriteLine("The given number  is an valid ISBN number={0}", s);
                }
                else
                {
                    Console.WriteLine("The given number is not an valid ISBN number");
                }
            

            
            Console.ReadLine();
        }
    }
}
