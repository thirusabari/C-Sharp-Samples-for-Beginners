using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication177
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzArray:");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
