using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  N number of limit");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, j;
            Console.WriteLine("The Right Angled Triagle is");
            Console.WriteLine("\n");
            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("\n");

            }
            Console.ReadLine();
        }
    }
}
