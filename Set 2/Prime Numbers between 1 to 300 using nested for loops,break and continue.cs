using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.WriteLine("Program to Find Prime Numbers between 1 to 300");
            Console.WriteLine("Enter the Maximum number of Range");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (i == j)
                {
                    Console.Write("{0} ",j);
                }
            }
            Console.ReadLine();

        }
    }
}
