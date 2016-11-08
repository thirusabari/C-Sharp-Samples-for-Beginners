using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Replace an word in the given string");
            string a = Console.ReadLine();
            string b = a.Replace("arasu", "sabari");
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
