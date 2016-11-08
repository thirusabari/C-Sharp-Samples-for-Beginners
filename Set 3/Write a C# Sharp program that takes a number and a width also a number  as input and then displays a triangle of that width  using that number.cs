using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Width for the Triangle");
            int w = Convert.ToInt16(Console.ReadLine());
            int b = a;
            int c;
            for (b = 0; b <=w; b++)
            {
                for (c = a; c >= b; c--)
                {
                    Console.Write(a);
                }
                Console.WriteLine("\n");
                
            }
            Console.ReadLine();
        
        }
    }
}
