using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String33
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char[] b;
            int i, L;
            Console.WriteLine("Converting odd places to Uppercase and even places to lowercase in a String");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the String");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            Console.WriteLine("\n\n\n");
            for (i =0; i <L; i++)
            {
                if (i % 2 == 0)
                {
                    if (b[i] >= 90)
                        b[i] = (char)(b[i] - 32);
                    if (b[i] <= 90)
                        b[i] = (char)(b[i] + 32);
                       
                }
                else
                {
                    if (b[i] <= 90)
                        b[i] = (char)(b[i] + 32);
                    if (b[i] >= 90)
                        b[i] = (char)(b[i] - 32);
                }
                Console.Write(b[i]);
            }
            Console.ReadLine();
        }
    }
}
