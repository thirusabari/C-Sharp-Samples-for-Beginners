using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] insert = new int[N];
            for (i = 0; i < N; i++)
            {
                insert[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The input Elements Entered Are:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(insert[i]);
            }
            List<int> Insert = new List<int>(insert);
            Insert.Add(5);
            Insert.Add(98);
            Insert.Sort();
            Console.WriteLine("The input Values After Sorted");
            foreach (int k in Insert)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
