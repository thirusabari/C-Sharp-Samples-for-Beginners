using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program to find the given number and reversed number or equal or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int  rem = 0; string sum = string.Empty;
            string n = num.ToString(); ;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem.ToString();
                num = num / 10;
            }
            if (n == sum)
            {
                Console.WriteLine("the Original Number and the reversed Number or equal");
            }
            else
            {
                Console.WriteLine("The original Number and the Reverse Number or not Equal");
            }
            Console.ReadLine();
        }
    }
}
