using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication175
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            int i, L,start=0,end=0;
            char[] a = s.ToCharArray();
            L = a.Length;
            for (i = 0; i < L; i++)
            {
                if ((a[i] == 'f'||a[i]=='F')&&i==0)
                {
                    start++;
                }
                if ((a[i] == 'b'||a[i]=='B')&&(i==L-1))
                {
                    end++;
                }
            }
            Console.WriteLine("\n");
            if (start == 1 && end == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (start == 0 && end == 1)
            {
                Console.WriteLine("Buzz");
            }
            else if (start == 1 && end == 1)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
            
        }
    }
}
