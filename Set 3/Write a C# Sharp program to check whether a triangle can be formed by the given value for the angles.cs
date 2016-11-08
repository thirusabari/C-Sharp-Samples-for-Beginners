using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Triangle Formation Checking");
            int angles;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            angles = a + b + c;
            if (angles == 180)
            {
                Console.WriteLine("The Triangle Formation is valid");

            }
            else
            {
                Console.WriteLine("The Triangle Formation is invalid");
            }
            Console.ReadLine();
        }
    }
}
