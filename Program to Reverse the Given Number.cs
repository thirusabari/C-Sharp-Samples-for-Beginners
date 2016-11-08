using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Reverse the given number");
            int num = Convert.ToInt32(Console.ReadLine());
            string sum = string.Empty;
            int remainder = 0,N;
            N = num;
            while (num != 0)
            {
                remainder = num % 10;
                sum = sum + remainder.ToString();
                num = num / 10;
            }
            Console.WriteLine("The reverse value of given number is={0}", sum);
            Console.ReadLine();
           
        }
    }
}
