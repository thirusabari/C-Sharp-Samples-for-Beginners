using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {

            int r, c,x=1;
            for (r = 0; r <= 24; r++)
            {
                for (c = 0; c <= 79; c++)
                {
                    Console.Write((char)x);
                }
            }
                
            
            Console.ReadLine();
        }
        
    }
}
