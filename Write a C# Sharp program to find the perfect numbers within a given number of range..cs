using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, sum = 0,k;
            Console.WriteLine("Check the Given number is Perfect Number or not");
            Console.WriteLine("Enter the Range");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <=n; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    k = i % j;
                    if (k == 0)
                    {
                        sum = sum + j;

                    }
                    }
                if (sum == i)
                {
                    Console.WriteLine("The  Given number is an perfect Number={0} and its sum of digits is={1}", i, sum);
                }
                
                
            }
            Console.ReadLine();
        }
    }
}
