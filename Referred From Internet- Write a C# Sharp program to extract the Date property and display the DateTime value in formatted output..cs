using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(2016, 9, 9, 11, 8, 00);
            Console.WriteLine("The Complete Date:" + a.ToString());

            DateTime dateOnly = a.Date;
            Console.WriteLine("The Short Date:" + dateOnly.ToString("d"));

            Console.WriteLine("Display the date using 24 hour clock format :");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
            Console.ReadLine();

        }
    }
}
