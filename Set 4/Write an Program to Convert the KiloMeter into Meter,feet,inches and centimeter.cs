using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double K_M, met, inches, feet, centimeter;
            Console.WriteLine("Write an Program to Convert Kilometer into meter,inches,feet,centimeter");
            Console.WriteLine("\n");
            K_M = Convert.ToDouble(Console.ReadLine());
            met = K_M * 1000;
            feet = K_M * 3280.84;
            inches = K_M * 39370.1;
            centimeter= K_M * 100000;
            Console.WriteLine("Kilometer in Meters={0}", met);
            Console.WriteLine("Kilometer in Feet={0}", feet);
            Console.WriteLine("Kilometer in inches={0}", inches);
            Console.WriteLine("Kilometer in centimeter={0}", centimeter);
            Console.ReadLine();
        }
    }
}
