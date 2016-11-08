using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter the start value:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the End value:");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, s = 0; 
            string[] fizzbuzz = new string[N];

            for ( i=k; i < N; i++)
            {
                if (i % 3 == 0&&i<15)
                {
                    
                    string three = "Fizz";
                    fizzbuzz[s] = three;
                    s++;
                }
                else if (i % 5 == 0&&i<15)
                {
                    string five = "Buzz";
                    fizzbuzz[s] = five;
                    s++;
                }
                else if (i % 5 == 0 && i % 3 == 0 && i > 10)
                {
                    string thrfiv = "FizzBuzz";
                    fizzbuzz[s] = thrfiv;
                    s++;
                }
                else
                {
                    fizzbuzz[s] = i.ToString();
                    s++;
                }
            }
            Console.WriteLine("\n");
            for (s = 0; s < N; s++)
            {
                Console.Write("{0} ", fizzbuzz[s]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
