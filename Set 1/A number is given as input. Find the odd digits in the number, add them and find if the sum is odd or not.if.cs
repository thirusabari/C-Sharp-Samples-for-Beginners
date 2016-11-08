using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            string num = Console.ReadLine();
            int i,L,sum=0;
            L = num.Length;
            for (i = 0; i < L; i++)
            {
                if (num[i] % 2 == 1)
                {
                    sum = sum + num[i];
                }
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("1");
            }

            Console.ReadLine();
        }
    }
}
