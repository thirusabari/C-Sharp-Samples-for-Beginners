using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raising_an_Number_to_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Power Value:");
            int power = Convert.ToInt16(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= power; i++)
            {
                sum = sum*num;
            }
            Console.WriteLine("The Expected Output is={0}", sum);
            Console.ReadLine();
            }
    }
}
