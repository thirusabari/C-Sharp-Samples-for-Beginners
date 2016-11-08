using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the Maximum value");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            float average;
            Console.WriteLine("Enter the  n number of values");
            for (i = 0; i <n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i = 1; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("The sum of 10 values is={0}", sum);
            average = sum / n;
            Console.WriteLine("The Average of 10 values is={0}", average);
            Console.ReadLine();
        }
    }
}
