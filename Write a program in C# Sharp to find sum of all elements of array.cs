using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i,sum=0;
            Console.WriteLine("Store a group of Array and Print it");


            for (i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                            
            }
            Console.WriteLine("The Entered input Values Are:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", a[i]);
                sum = sum + a[i];
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("The sum of Values are={0}", sum);
            Console.ReadLine();
        }
    }
}
