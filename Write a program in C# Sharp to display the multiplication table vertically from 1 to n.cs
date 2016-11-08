using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication table upto n Numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int i,j,c;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    c = i * j;
                    Console.Write("{0}*{1}={2},  ", i, j, c);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
