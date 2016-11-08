using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            float radius = Convert.ToSingle(Console.ReadLine());
            double Surfacearea,volume;
            Surfacearea = 4 * pi *(radius * radius);
            volume = (4/3) * pi * (radius * radius * radius);
            Console.WriteLine("The Surface Area of sphere is={0}", Surfacearea);
            Console.WriteLine("The Volume of Sphere is={0}", volume);
            Console.ReadLine();
 
        }
    }
}
