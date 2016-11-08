using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication172
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            int L, i, j,count=1,m=0,Max=0;
            L = a.Length;
            int[] max = new int[L];
            for (i = 0; i < L; i++)
            {
                for (j = i+1; j < L-1; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                    else
                    {
                        if (count != 1)
                        {
                            max[m] = count;
                            m++;
                            count = 1;
                        }
                    }

                }
            }
            j = m;
            for (m = 0; m <= j; m++)
            {
                if (max[m] > Max)
                {
                    Max = max[m];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(Max);
            Console.ReadLine();

        }
    }
}
