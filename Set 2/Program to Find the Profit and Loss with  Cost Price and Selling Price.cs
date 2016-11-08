using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find Profit and Loss with Cost Price and Selling Price");
            int sell_p = Convert.ToInt32(Console.ReadLine());
            int cost_p = Convert.ToInt32(Console.ReadLine());
            int profit, loss;
            if (sell_p > cost_p)
            {
                profit = sell_p - cost_p;
                Console.WriteLine("The owner have profit only={0}", profit);
            }
            else if (cost_p > sell_p)
            {
                loss = cost_p - sell_p;
                Console.WriteLine("the owner suffers from loss={0}", loss);
            }
            else
            {
                Console.WriteLine("the owner in no profit and no loss situation");
            }
            Console.ReadLine();
        }
    }
}
