using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            for (a = 'A'; a <= 'C'; a++)
            {
                for (b = 'A'; b <= 'C'; b++)
                {
                    for (c = 'A'; c <= 'C'; c++)
                    {
                        Console.WriteLine("{0}{1}{2}", a, b, c);
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
