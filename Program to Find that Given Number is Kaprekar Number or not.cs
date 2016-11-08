using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprekar_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Given number is Kaprekar Number or not");
            int num = Convert.ToInt32(Console.ReadLine());
            string sum = string.Empty;
            string sum1 = string.Empty;
            int i, j,L,n,kaprekar; long square; 
            string a;
            square = num * num;
             a = square.ToString();
                L = a.Length;
                n = L / 2;
                for (i = 0; i < n; i++)
                {
                    sum = sum + a[i];
                }
                for (j = n; j < L; j++)
                {
                    sum1 = sum1 + a[j];
                }
                      
            kaprekar = Convert.ToInt32(sum) + Convert.ToInt32(sum1);
            if (kaprekar == num)
            {
                Console.WriteLine("The given number is an Kaprekar number {0}={1}", kaprekar,num);
            }
            else
            {
                Console.WriteLine("The given number is not an kaprekar number ");
            }
            Console.ReadLine();

        }
    }
}
