using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i;
            Console.WriteLine("Store a group of Array and Print it");


            for (i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Array Contains Following Values:");
            for (i = a.Length-1; i >=0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
