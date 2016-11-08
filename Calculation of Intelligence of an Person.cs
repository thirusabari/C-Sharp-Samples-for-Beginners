using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, y; double x,i;
            Console.WriteLine("Calculation of Intelligence of a Person for Different Ranges");
            for (y = 1; y <= 6; y++)
            {
                for (x = 5.5; x <= 12.5; x += 0.5)
                {
                    i=(2+(y+0.5*x));
                    n++;
                    Console.WriteLine("y={0},x={1},i={2}",y,x,i);
                    if (n >= 24)
                    {
                        n = 0;
                        break;
                    }
                }
                
            }
            Console.ReadLine();

        }
    }
}
