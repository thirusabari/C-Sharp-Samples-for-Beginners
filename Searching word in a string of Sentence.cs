using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConversion37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search a Word in Given String");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            foreach (string c in b)
            {
                if (c == "arasu")
                {
                    Console.WriteLine("the expected word found={0}", c);
                }
            }
            Console.ReadLine();
        }
    }
}
