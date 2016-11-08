using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            Console.WriteLine("Enter the Series no:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Maximum limit for the Table:");
            int n = Convert.ToInt16(Console.ReadLine());
            int mul;
            for (int i = 1; i <= n; i++)
            {
                mul= a * i;
                Console.WriteLine("{0}*{1}={2}",a,i,mul);
            }
            Console.ReadLine();
        }
    }
}
