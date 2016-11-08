using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            int i, L,j,count=0;
            char[] b = a.ToCharArray();
            L = b.Length;
            char[] A = b;
            for (i = 0; i < L; i++)
            {
                for (j = i+1; j < L; j++)
                {
                    if (A[i] == b[j])
                    {
                        continue;
                    }
                    else
                    {
                        count++;

                    }
                    
                }
                break;
            }
            Console.WriteLine("\n");
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
