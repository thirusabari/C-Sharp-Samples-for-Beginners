using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            var name = a.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                int m = name[i] - 32;
                Console.WriteLine(" the char is {0}", (char)m);

            }
            Console.ReadLine();
        }
    }
}
