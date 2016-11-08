using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication194
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GroupSUm");
            Console.WriteLine("\n");
            Console.WriteLine("enter the target value:");
            int target = Convert.ToInt32(Console.ReadLine());
            int i,j,count=0,sum=0;
            Console.WriteLine("Enter the Maximum Range for the input  Array:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                count++;
                for (j = i + 1; j < N; j++)
                {
                    sum = a[i] + a[j];
                    if (sum == target)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        sum = 0;
                        break;
                    }
                }
                
            }
            sum = 0; i = 0; j = 0; int c1 = 0;
            while(count == N)
            {
                   sum = a[0] + a[N-1];
                    if (sum == target)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        
                        c1++;
                    }
                
                if (c1 == 1)
                {
                    sum = 0;
                    for (i = 0; i < N; i++)
                    {
                        sum = sum + a[i];
                    }
                    if (sum == target)
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
