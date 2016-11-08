using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping12a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, space, rows, k,l=1;
            Console.WriteLine("Pyramid Set with Flyod's Triangle");
            Console.WriteLine("Enter the Maximum number of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            space = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i;k++ )
                {
                    Console.Write("{0}     ", l);
                    l++;

                }
                space--;
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
