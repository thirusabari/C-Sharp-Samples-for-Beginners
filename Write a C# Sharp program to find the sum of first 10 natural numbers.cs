using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum of  First 10 Natural Numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
