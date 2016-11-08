using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String23
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c,d;
            Console.WriteLine("Concatenation of 3 strings");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = string.Concat(a, b, c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
