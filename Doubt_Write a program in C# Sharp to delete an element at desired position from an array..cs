using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,position;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the input Elements to the Array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Input Elements entered are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Enter the Position of the Values to be Deleted");
            position = Convert.ToInt32(Console.ReadLine());
            for (i = position; i <=N; i++)
            {
                a[position] = a[i+1];
            }
            Console.WriteLine("After the Positioned Values deleted");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
