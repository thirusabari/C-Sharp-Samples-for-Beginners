using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangla checking");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (a == b || a== c||b==c)
            {
                Console.WriteLine("Isosceles Triangle");

            }
            else if(a!=b&&b!=c&&c!=a)
            {
                Console.WriteLine("Scalene Triangle");
            }
            Console.ReadLine();
        }
    }
}
