using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            string octal = string.Empty;
            int num, remainder,N; string sum = string.Empty;
            Console.WriteLine("Program to Convert the Given Number into Octal Equivalent Number");
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            N = num;
            while (num != 0)
            {
                remainder = num % 8;
                sum = sum + remainder.ToString();
                num = num / 8;
            }
            for (int i = sum.Length-1; i>=0; i--)
            {
                octal = octal + sum[i];
            }
            Console.WriteLine("The Octal Equivalent Value is={0}", octal);
            Console.ReadLine();
        }
    }
}
