using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the Number of Inputs Entered by the user");
            Console.WriteLine("Entert the Maximum Range of the Values:");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, c1=0,c2=0,c3=0;
            int[] a = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Counting of Number of inputs");
            for (i = 0; i < N; i++)
            {
                if (a[i] > 0)
                {
                    c1++;
                }
                else if (a[i] < 0)
                {
                    c2++;
                }
                else if (a[i] == 0)
                {
                    c3++;
                }
            }
            Console.WriteLine("The Number of Positive values counted:{0}", c1);
            Console.WriteLine("The Number of Negative values counted:{0}", c2);
            Console.WriteLine("The Number of Zeroes counted:{0}", c3);

            Console.ReadLine();
        }
    }
}
