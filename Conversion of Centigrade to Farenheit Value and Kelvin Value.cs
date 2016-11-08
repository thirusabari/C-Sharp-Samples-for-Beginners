using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_of_Centigrade_toFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Centigrade Value:");
            double c = Convert.ToDouble(Console.ReadLine());
            double f,k;
            f = c * 9 / 5 + 32;
            k = c + 273;
            Console.WriteLine("The FahrenHeit Value is={0}", f);
            Console.WriteLine("The Kelvin Value is={0}", k);
            Console.ReadLine();
        }
    }
}
