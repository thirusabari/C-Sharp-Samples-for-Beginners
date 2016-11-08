using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication139
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string a = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write(a);
            }
            Console.ReadLine();
        }
    }
}
