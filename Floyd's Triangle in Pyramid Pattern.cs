using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Print Floyd's Triangle as given");
            int i, j,k, rows,space=0,a=1;
            rows = Convert.ToInt32(Console.ReadLine());
            space =rows+4 - 1;
            for (i = 0; i <=rows; i++)
            {
                for (j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("{0} ",a);
                    a++;
                }
                space--;
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
