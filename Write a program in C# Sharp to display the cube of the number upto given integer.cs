using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Values of Cube");
            int n = Convert.ToInt32(Console.ReadLine());
            int cube;
            for (int i = 1; i <= n; i++)
            {
                cube = i * i * i;
                Console.WriteLine("The cube of number {0} is={1}", i, cube);
            }
            Console.ReadLine();
        }
    }
}
