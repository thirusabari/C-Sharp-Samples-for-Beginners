using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrade, Farenheit;
            Console.WriteLine("Calculate Farenheit with Centigrade");
            Console.WriteLine("\n");
            centigrade = Convert.ToDouble(Console.ReadLine());
            Farenheit = centigrade * (9 / 5) + 32;
            Console.WriteLine("The Farenheit Value={0}", Farenheit);
            Console.ReadLine();
        }
    }
}
