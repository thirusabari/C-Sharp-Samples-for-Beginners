using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu  Given Below for  Find the Area");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your choice given in Menu");
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Parallelogram");
            Console.WriteLine("4.Triangle");
            Console.WriteLine("5.Circle");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Area of Square");
                    int side = a;
                    int area = side * side;
                    Console.WriteLine("The area of Square is={0}", area);
                    break;
                case 2:
                    Console.WriteLine("Area of Rectangle");
                    int length = a;
                    int width = b;
                    int Area = length * width;
                    Console.WriteLine("The area of Rectangle is={0}", Area);
                    break;
                case 3:
                    Console.WriteLine("Area of Parallelogram");
                    int Base=a;
                    int height = b;
                    int area3 = Base * height;
                    Console.WriteLine("The area of Parallelogram={0}", area3);
                    break;
                case 4:
                    Console.WriteLine("Area of Triangle");
                    int Base1 = a;
                    int height1 = b;
                    int area4 = Base1 * height1/2;
                    Console.WriteLine("The area of Triangle={0}", area4);
                    break;
                case 5:
                    Console.WriteLine("The Area of Cube");
                    int side1 = a;
                    int area5 = 6 * side1 * side1;
                    Console.WriteLine("The area of Cube is={0}", area5);
                    break;
                default:
                    Console.WriteLine("Wrong Choice Value Entered");
                    break;
            }
            Console.ReadLine();
        }
    }
}
