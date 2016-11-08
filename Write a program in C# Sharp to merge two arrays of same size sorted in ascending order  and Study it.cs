using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,N1,N2,k,n;
            Console.WriteLine("Enter the Maximum Range of an Array:");
            N1 = Convert.ToInt32(Console.ReadLine());
            int[] a=new int[10];
            int[] b = new int[10];
            int[] c = new int[10]; ;
            Console.WriteLine("Enter the input Elements for the first Array");
            for (i = 0; i < N1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input Elements for the Second Array");
            
            for (j = 0; j < N2; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
                 
            }
            n = N1 + N2;
            //insert in Third Array;
            for (i = 0; i < N1; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < N2; j++)
            {
                c[i] = a[j];
                i++;

            }
            //Sorting the Third Array to Ascending Order
            for (i = 0; i < n; i++)
            {
                for (k = 0; k < n - 1; k++)
                {
                    if (c[k] >= c[k + 1])
                    {
                        j = c[k + 1];
                        c[k + 1] = c[k];
                        c[k] = j;
                    }
                }
            }
            //print the merged Array
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.ReadLine();

        }
    }
}
