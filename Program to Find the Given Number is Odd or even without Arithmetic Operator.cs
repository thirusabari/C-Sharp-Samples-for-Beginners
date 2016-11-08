using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication85
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int x;
            x = num & 1;
            Console.WriteLine("x={0}", x);
            if (x == 0)
            {
                Console.WriteLine("even number={0}", num);
            }
            else
            {
                Console.WriteLine("odd number={0}", num);
            }
            Console.ReadLine();
        }
    }
}
