using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 1,i,count=0,sub;
            for (i = 3; i <= N; i = i + 2)
            {
                count++;
                if (count == 2)
                {
                    sub = sum - i;
                    sum = sub;
                    count = 0;
                    continue;
                }
                sum = sum + i;

            }
            Console.WriteLine("The sum value is={0}", sum);
            Console.ReadLine();

        }
    }
}
