using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping27
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 0,N,rows,c=1;
            Console.WriteLine("Pascal Triangle");
            Console.WriteLine("Enter the N Value:");
            rows = Convert.ToInt32(Console.ReadLine());
            N = rows + 4 - 1;
            for (i = 0; i <= rows; i++)
            {
                for (j = N; j >=1; j--)
                {
                    Console.Write(" ");
                    
                }
                for (k = 0; k <= i;k++)
                {
                    if (k ==0||i==0)
                    {
                        c = 1;
                        
                    }
                    else 
                    {
                        c = c * (i - k + 1) / k;
                    }
                    Console.Write("{0} ", c);

                }
                                 
                Console.WriteLine("\n");
                N--;
                    
            }
            
            
            Console.ReadLine();
        }
    }
}
