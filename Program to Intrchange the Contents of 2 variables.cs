using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program to Interchange the Contents of 2 Variables");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            temp = c;
            c = d;
            d = temp;
            Console.WriteLine("After the Interchange the values are={0} {1}", c, d);
            Console.ReadLine();
        }
    }
}
