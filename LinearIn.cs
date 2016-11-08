using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication187
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maximum Range of First Array:");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range of Second Array:");
            int N2 = Convert.ToInt32(Console.ReadLine());
            int[] ar1 = new int[N1];
            int[] ar2 = new int[N2];
            int n1 = N1 - 1;
            int n2 = N2 - 1;
            int[] dif1 = new int[n1];
            int[] dif2 = new int[n1];
            int d1 = 0, d2 = 0;
            int i, j,count1=0,count2=0,diff1=0,diff2=0,count=0;
            Console.WriteLine("Enter the Values for first array:");
            for (i = 0; i < N1; i++)
            {
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ENter the values for second array:");
            for (j = 0; j < N2; j++)
            {
                ar2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The first array contains:");
            for (i = 0; i < N1; i++)
            {
                Console.Write("{0} ", ar1[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Second Array Contains:");
            for (j = 0; j < N2; j++)
            {
                Console.Write("{0} ", ar2[j]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N1-1; i++)
            {
                diff1 = ar1[i] - ar1[i + 1];
                dif1[d1] = diff1;
                Console.Write("{0} ", diff1);
                d1++;
                diff1 = 0;
            }
            Console.WriteLine("\n");
            for (j = 0; j < N2-1; j++)
            {
                diff2 = ar2[j] - ar2[j + 1];
                dif2[d2] = diff2;
                Console.Write("{0} ", diff2);
                d2++;
                diff2 = 0;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            for (j = 0; j < N2; j++)
            {
                for (i = 0; i < N1; i++)
                {
                    if (ar2[j] == ar1[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(count);
            i = 0; i = d1;
            j = 0; j = d2;
            for (d1 = 0; d1 < i-1; d1++)
            {
                if (dif1[d1] == dif1[d1 + 1] )
                {
                    count1++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(count1);
            for (d2 = 0; d2 < j - 1; d2++)
            {
                if (dif2[d2] == dif2[d2 + 1] )
                {
                    count2++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(count2);
            Console.WriteLine("\n");
            if (count == N2 || count > N2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("\n");
            Console.ReadLine();


        }
    }
}
