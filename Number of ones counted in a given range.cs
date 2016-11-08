using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" number of one counting");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Minimum Limit");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maximum Limit");
            int max = Convert.ToInt32(Console.ReadLine());
            int i, j,count = 0,L,c1=0,c2=0; string ones = string.Empty;
            for (i = min; i <= max; i++)
            {
                ones = ones + i;
                L = ones.Length;
                if (L== 1)
                {
                    if (ones == "1")
                    {
                        count++;
                    }
                }
                else if (L > 1)
                {
                    char[] a = ones.ToCharArray();
                    int L1 = a.Length;
                    for (j = 0; j < L1; j++)
                    {
                        if (a[j] == '1')
                        {
                            count++;
                        }
                        if (a[j] == '0')
                        {
                            continue;
                        }
                    }
                }
                ones = string.Empty;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(count);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
