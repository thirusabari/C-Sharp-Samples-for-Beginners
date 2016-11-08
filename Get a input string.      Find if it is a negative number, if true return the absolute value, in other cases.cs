using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication116
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            int i, L,count=0;
            string sum = string.Empty;
            char[] b = a.ToCharArray();
            L = b.Length;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            for (i = 0; i < L; i++)
            {
                if (b[i] == '-')
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    sum = sum + b[i];
                    if (i == L - 1)
                    {
                        Console.WriteLine("Absolute Number is={0}", sum);
                    }
                }
                else
                {
                    Console.WriteLine("-1");
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
