using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[2];
            for (i = 0; i < 2; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
               if (((a[0] % 2) == 0) && ((a[1] % 2) == 0))
                {
                    Console.WriteLine(true);

                }
                else
                {
                    Console.WriteLine(false);
                }
           Console.ReadLine();
        }
    }
}
