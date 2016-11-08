using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Quadrant which the Coordinate point lies");
            int co1 = Convert.ToInt32(Console.ReadLine());
            int co2 = Convert.ToInt32(Console.ReadLine());
            if (co1 > 0 && co2 > 0)
            {
                Console.WriteLine("The Quadrant ({0},{1}) lies in First Quadrant", co1, co2);
            }
            else if (co1 < 0 && co2 > 0)
            {
                Console.WriteLine("The Quadrant ({0},{1}) lies in Second Quadrant", co1, co2);
            }
            else if (co1 < 0 && co2 < 0)
            {
                Console.WriteLine("The Quadrant ({0},{1}) lies in Third Quadrant", co1, co2);
            }
            else if (co1 > 0 && co2 < 0)
            {
                Console.WriteLine("The Quadrant ({0},{1}) lies in Fourth Quadrant", co1, co2);
            }
            else if (co1 == 0 && co2 == 0)
            {
                Console.WriteLine("The Quadrant ({0},{1}) lies in Origin", co1, co2);
            }
            Console.ReadLine();
        }
    }
}
