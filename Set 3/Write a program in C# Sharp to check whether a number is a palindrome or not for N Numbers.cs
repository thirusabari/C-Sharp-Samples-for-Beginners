using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping30
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, rem,i,I;
            Console.WriteLine("Number Reverse");
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
          
            for (i = 1; i <= number; i++)
            {
                sum = 0;
                I = i;
                while (I != 0)
                {
                    rem = I % 10;
                    sum = sum * 10 + rem;
                    I = I / 10;
                }
                if (sum == i)
                {
                    Console.WriteLine("The Given Number {0} is an Palindrome={1}", i, sum);
                }
                
            }
                Console.ReadLine();
            
        }
    }
}
