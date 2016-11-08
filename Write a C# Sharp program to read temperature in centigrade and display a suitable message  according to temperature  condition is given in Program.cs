using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Temperature = Convert.ToInt32(Console.ReadLine());
            if (Temperature < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if (Temperature >= 0 && Temperature <= 10)
            {
                Console.WriteLine("Very Cold Weather");
            }
            else if (Temperature > 10 && Temperature <= 20)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (Temperature > 20 && Temperature <= 30)
            {
                Console.WriteLine("Normal In Temperature");
            }
            else if (Temperature > 30 && Temperature <= 40)
            {
                Console.WriteLine("It's Hot");
            }
            else if (Temperature >= 40)
            {
                Console.WriteLine("It's Very Hot");
            }
            Console.ReadLine();
        }
    }
}
