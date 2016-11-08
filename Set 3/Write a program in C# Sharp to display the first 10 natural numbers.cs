using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natural Numbers from 1 to 10");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
