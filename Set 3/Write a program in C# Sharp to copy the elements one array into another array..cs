using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i,j;
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
            int[] b = a;
            Console.WriteLine("The elements Copied to Second Array are:");
            Console.WriteLine("\n");
            for (j = 0; j < a.Length; j++)
            {
                Console.Write("{0} ", b[j]);
            }
            Console.ReadLine();
        }
    }
}
