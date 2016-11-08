using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Area of Rectangle is Greater than Perimeter of Rectangle or not");
            int Length = Convert.ToInt32(Console.ReadLine());
            int Breadth = Convert.ToInt32(Console.ReadLine());
            double Area, Perimeter;
            Area = Length * Breadth;
            Perimeter = 2 * (Length + Breadth);
            if (Area > Perimeter)
            {
                Console.WriteLine("The Area of Rectangle is Greater than Perimeter {0}={1}", Area, Perimeter);
            }
            else if (Area == Perimeter)
            {
                Console.WriteLine("The Area of Rectangle is Equal to the Perimeter of Rectangle {0}={1}", Area, Perimeter);
            }
            else
            {
                Console.WriteLine("The Area of Rectangle is Lesser than Perimeter {0}={1}", Area, Perimeter);
            }
            Console.ReadLine();
        }
    }
}
