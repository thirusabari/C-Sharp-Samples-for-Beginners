using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication146
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem, N;
            N = n;
            
            while (N != 0)
            {
                rem = N % 10;
                sum = sum + rem;
                N = N / 10;
                if (sum == rem)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    N = sum;
                    sum = 0;
                    continue;
                }
                
            }
            Console.ReadLine();
        }
    }
}
