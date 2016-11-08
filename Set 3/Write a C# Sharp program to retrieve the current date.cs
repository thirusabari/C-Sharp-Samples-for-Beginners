using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("General Format is:" + thisDay.ToString());
            Console.WriteLine("Display the date of variety of formats:");
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(thisDay.ToString("g"));
            Console.ReadLine();
        }
    }
}
