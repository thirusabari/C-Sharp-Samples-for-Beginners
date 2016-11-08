using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, j,count = 0;
            Console.WriteLine("Program to Copy one array into another array");


            for (i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The First Array Contains");
            Console.WriteLine("\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < 10;i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The number of Duplicate Elements Present in Array is={0}", count);
            Console.ReadLine();
        }
    }
}
