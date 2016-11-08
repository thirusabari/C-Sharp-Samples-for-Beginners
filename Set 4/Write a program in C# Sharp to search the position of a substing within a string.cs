using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String18
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Search the position of an substring in a string");
            Console.WriteLine("Enter the string");
            a = Console.ReadLine();
            Console.WriteLine("Enter the SubString");
            b = Console.ReadLine();
            int index = a.IndexOf(b);
            if (index < 0)
            {
                Console.WriteLine("there is no substring find in the string");

            }
            else
                Console.WriteLine("the string {0} found substring of {1} at  position {2}", a, b, index);
            Console.ReadLine();
        }
    }
}
