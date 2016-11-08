using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Jagged Arrays");
            int[][] a = new int[][]
            {
                new int[]{1,2,3,4,5},
                new int[]{30,40,50},
                new int[]{50,100}
            };
            for(i=0;i<a.Length;i++)
            {
                for(j=0;j<2;j++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
