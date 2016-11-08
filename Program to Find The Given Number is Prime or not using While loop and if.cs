using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to the Given Number is Prime Number or not using While loop");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i <= num - 1)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("The Given Number is not Prime");
                    break;
                }
                i++;
            }
            if (num == i)
            {
                Console.WriteLine("The Given Number is an Prime Number {0}={1}", num, i);
            }
            Console.ReadLine();
            
        }
    }
}
