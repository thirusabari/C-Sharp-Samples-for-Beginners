using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, k = 0, count = 1, c = 0;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] consec = new int[N];
            Console.WriteLine("Enter the elements");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                count = 1;
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                                               
                        if (count == 3 || count == 4 || count == 5 || count == 6 || count == 7 || count == 8 || count == 9 || count == 10)
                        {
                            consec[k] = count;
                            k++;
                            c++;

                            break;
                        }


                    }
                }
                
                
            }
            Console.WriteLine("\n");
            for (k = 0; k <c; k++)
            {
                Console.Write("{0},", consec[k]);
            }
            Console.ReadLine();
        }
    }
}
