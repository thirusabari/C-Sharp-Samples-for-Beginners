using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Last Samples");
            Console.WriteLine("ENter the M values");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the N values");
            int N = Convert.ToInt32(Console.ReadLine());
            int i,count=0;
            for (i = M - 1; i > N; i--)
            {
                count++;
                Console.Write("{0} ", i);
                if (count == N)
                {
                    break;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
