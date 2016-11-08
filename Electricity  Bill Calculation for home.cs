using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity
{
    class Program
    {
        static void Main(string[] args)
        {
            int units = Convert.ToInt16(Console.ReadLine());
            int pc1, pc2,pc3,a,b;
            Console.WriteLine("The Electricity  Bill  Calculation");
            if (units <= 100)
            {

                pc1 = (units * 5);
                Console.WriteLine("The power Consumption is={0}", pc1);

            }
            else if (units > 100 && units <= 200)
            {
                a= units - 100;
                pc2 = (a * 10) + 500;
                Console.WriteLine("The power Consumption is={0}", pc2);

            }
            else if (units > 200 && units <= 250)
            {
                b = units - 200;
                pc3 = (b * 15) + 500 + 1000;
                Console.WriteLine("The Power Consumption is={0}", pc3);
            }

            Console.ReadKey();
        }
    }
}
