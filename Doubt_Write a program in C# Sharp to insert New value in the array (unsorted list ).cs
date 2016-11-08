using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,position,value;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the input Values for the Array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Elements Entered are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Enter the new Value for Array");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the position of the Value Added to the Array");
            position = Convert.ToInt32(Console.ReadLine());
            for (i = N; i >= position; i--)
            {
                //a[i] = a[i- 1];
                a[position - 1] = value;
                N = N + 1;
            }
            Console.WriteLine("The Elements of the Array After the new Value Added");
            for (i = 0; i <N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();

        }
    }
}
