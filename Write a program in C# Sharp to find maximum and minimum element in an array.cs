using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N, j,Maximum,Minimum;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Input Elements of the Array");
            int[] a = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Elements Entered are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Maximum = a[0];
            Minimum = a[0];
           
            for (i = 0; i < N; i++)
            {
                if (a[i] > Maximum) 
                {
                    Maximum = a[i];
                    
                }
            }
            for (j = 0; j < N; j++)
            {
                if (a[j] < Minimum)
                {
                    Minimum = a[j];
                }
            }
            Console.WriteLine("The Entered Array Contains Maximum and Minimum Values as ={0} and {1}", Maximum, Minimum);
            Console.ReadLine();
        }
    }
}
