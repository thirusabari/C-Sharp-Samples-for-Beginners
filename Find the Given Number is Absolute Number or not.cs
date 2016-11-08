using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Given Number is Absolute Number or not");
            int Absolute = Convert.ToInt32(Console.ReadLine());
            int num;
            if (Absolute > 0||Absolute==0)
            {
                num = Absolute;
                Console.WriteLine("The Absolute Number of {0} is={1}", Absolute, num);
            }
            else if (Absolute < 0)
            {
                num = -1 * Absolute;
                Console.WriteLine("The Absolute Number of {0} is={1}", Absolute, num);
            }
            
            
        Console.ReadLine(); 
        }
    }
}
