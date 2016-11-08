using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping17
{
    class Program
    {
        static void Main(string[] args)
        {
            double  x, d, N;
            double t = 1;
            double sum=1;
            Console.WriteLine("The sum of Series");
            Console.WriteLine("Enter the Input Value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Series Range");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                d = (2 * i)*(2 * i - 1);
                t = -t * x * x / d;
                sum = sum + t;

            }
            Console.WriteLine("The sum of {0} terms:{1} value of x={2}", sum, N, x);
            Console.ReadLine();
        }
    }
}
