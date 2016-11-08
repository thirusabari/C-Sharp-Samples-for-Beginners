using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, key, position, N,lb,ub,mid;
            Console.WriteLine("Binary Search Implementation");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the  N Elements of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] a = new int[N];
            Console.WriteLine("Enter the input Values For the Array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Input array Contains Following Elements:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            lb = 0;
            ub = N - 1;
            Console.WriteLine("enter the key Elements to be searched");
            key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("The Search Successful:");
            for (j = 0; j < N; j++)
            {
                
                while (ub >= lb)
                {
                    mid = (ub + lb) / 2;
                    if (key < a[mid])
                    {
                        ub = mid - 1;
                    }
                    else if (key > a[mid])
                    {
                        lb = mid + 1;
                    }
                    else if (key == a[mid])
                    {
                        position = mid;
                        Console.Write(position);
                        lb = N;
                        break;
                        
                    }
                    
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
