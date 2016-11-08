using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the Series of Abundant Numbers:");
            int M = Convert.ToInt32(Console.ReadLine());
            int i, n, sum = 0;
            n = M;
            while (0<M)
            {
                sum = 0;
                for (i = 1; i < M; i++)
                {
                    if (M % i == 0)
                    {
                        sum = sum + i;
                    }
                    else
                    {
                        continue;
                    }
                }
                
                if (sum > M)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("The Given Number is {0} an Abundant Number ={1}", M, sum);
                }
                
                    M--;
                
            } 
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
