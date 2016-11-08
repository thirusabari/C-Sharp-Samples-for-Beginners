using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation of total number of Currency notes");
            int d1 = 10;
            int d2 = 50;
            int d3 = 100;
            int currency = Convert.ToInt32(Console.ReadLine());
            int totalamount = currency * d1 + currency * d2 + currency * d3;
            Console.WriteLine("The TotalAmount WithDrawn by the cashier={0}", totalamount);
            Console.ReadLine();

        }
    }
}
