using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N, position;string value;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            Console.WriteLine("Enter the input Values for the Array");
            for (i = 0; i < N; i++)
            {
                a[i] =Console.ReadLine();
            }
            Console.WriteLine("The input Elements Entered are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Enter the new Value for Array");
            value = Console.ReadLine();
            Console.WriteLine("Enter the position of the Value Added to the Array");
            position = Convert.ToInt32(Console.ReadLine());
            for (i = N-1; i >= position-1; i--)
            {
                
                a[position - 1] = value;
              
                
                
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
