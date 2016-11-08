using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, space, rows;
            Console.WriteLine("Enter the Maximum Number of Rows");
            rows = Convert.ToInt32(Console.ReadLine());
            space = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (k = 0; k != 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
                space--;
            }
            Console.ReadLine();

        }
    }
}
