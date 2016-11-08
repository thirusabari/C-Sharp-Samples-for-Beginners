using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length, Breadth, Area,radius,perimeter;
            double pi = 3.14; double area_circle, Circumference;
            Length = Convert.ToInt32(Console.ReadLine());
            Breadth = Convert.ToInt32(Console.ReadLine());
            Area = Length * Breadth;
            perimeter = 2 * (Length + Breadth);
            Console.WriteLine("The Area of Rectangle is={0}", Area);
            Console.WriteLine("The Perimeter of Rectangle is={0}", perimeter);
            radius = Convert.ToInt32(Console.ReadLine());
            area_circle = pi * radius * radius;
            Circumference = 2 * pi * radius;
            Console.WriteLine("The Area of Circle is={0}",area_circle);
            Console.WriteLine("The Circumference of circle is={0}",Circumference);
            Console.ReadLine();

        }
    }
}
