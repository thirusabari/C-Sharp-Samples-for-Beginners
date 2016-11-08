using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int selling_price = 15;
            int profit = Convert.ToInt32(Console.ReadLine());
            int cost_price = profit - selling_price;
            Console.WriteLine("the cost price is={0}", cost_price);
            Console.ReadLine();
        }
    }
}
