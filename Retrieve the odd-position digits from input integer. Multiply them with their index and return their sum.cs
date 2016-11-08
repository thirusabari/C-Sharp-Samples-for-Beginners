using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication136
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, sum = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[N];
            for (i = 0; i < N; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (i = 1; i < N; i = i + 2)
            {
                sum = sum + num[i] *i;
            }
            Console.WriteLine("\n");
            Console.WriteLine("The odd index position and its multiplication values are={0}", sum);
            Console.ReadLine();
        }
    }
}
