using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,k,I,J,K, space,rows;
            Console.WriteLine("Diamond Shape Asterisk");
            Console.WriteLine("Enter the number of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            space = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for(k=1;k<=2*i-1;k++)
                {
                    Console.Write("*");
                    
                }
                
                Console.WriteLine("\n");
                space--;
            }
            
            for (J = rows-1; J >= 1;J--)
            {
                for (I = 1; I <= rows;I++ )
                {
                    Console.Write(" ");
                }
                for (K = 2 * J-1; K >= 1; K--)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\n ");
                
            }
            Console.ReadLine();

        }
    }
}
