using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String31
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int i,L;
            char[] b;
            Console.WriteLine("Converting an string to uppercase");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the  String:");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            for (i = 0; i < L; i++)
            {
                    b[i] = (char)(b[i] - 32);
                    Console.Write(b[i]);
            }
            
            Console.ReadLine();

        }
    }
}
