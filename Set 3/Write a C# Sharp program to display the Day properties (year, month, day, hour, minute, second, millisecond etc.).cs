using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime b = new DateTime(2016, 9, 9, 11, 15, 49,14);
            Console.WriteLine("Year:" + b.Year);
            Console.WriteLine("Month:" + b.Month);
            Console.WriteLine("Day:" + b.Day);
            Console.WriteLine("hour:" + b.Hour);
            Console.WriteLine("Minute:" + b.Minute);
            Console.WriteLine("Seconds:" + b.Second);
            Console.WriteLine("MilliSeconds:" + b.Millisecond);
            Console.ReadLine();
        }
    }
}
