using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirunavukkarasu_Code2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem; int Q; int sum = 0;
            int Prime, Prime1; int compare;
            for (int i = 1; i < 100; i++)
            {


                rem = i % 10;
                Q = i / 10;
                sum = rem + Q;
                if(sum%2==1)
                {
                    Console.WriteLine("The Given number is an Prime NUMBER:{0} and {1}", i, sum);
                }
            }
            Console.ReadKey();
        }

    }
}
