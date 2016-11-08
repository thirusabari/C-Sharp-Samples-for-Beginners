using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    for (k = 1; k <= 3; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
