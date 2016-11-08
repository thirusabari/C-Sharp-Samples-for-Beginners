using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int  a = 1,remainder,N,SUM,i;
            string sum = string.Empty; string b = string.Empty;
            N = num;
            while (num != 0)
            {
                SUM = 0;
                remainder = num % 10;
               SUM = a + remainder;
               sum = sum + SUM.ToString();
                num = num / 10;
            }
            for (i = sum.Length-1; i >= 0; i--)
            {
                b= b + sum[i];
            }
            Console.WriteLine("the new number is={0}", b);

            Console.ReadLine();


        }
    }
}
