using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 1;
            Console.WriteLine("Flyod's Triangle");
            Console.WriteLine("Enter the N terms of Maximum Limit");
            int N = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    k++;
                }
            }
            Console.ReadLine();
        }
    }
}
