using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyramid View with asterisk Symbol");
            int i, j, k,N,space;
            Console.WriteLine("Enter the N Number of Rows");
            N = Convert.ToInt32(Console.ReadLine());
            space = N + 4 - 1;
            for (i = 1; i <= N; i++)
            {
                for (j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                   
                   
                }
                Console.WriteLine("\n");
                space--;
            }
            Console.ReadLine();
            
        }
    }
}
