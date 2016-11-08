using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic20
{
    class Program
    {
        static void Main(string[] args)
        {
            int costprice, selledprice, plannedamount;
            costprice = Convert.ToInt32(Console.ReadLine());
            selledprice = Convert.ToInt32(Console.ReadLine());
            if (selledprice > costprice)
            {
                plannedamount = selledprice - costprice;
                Console.WriteLine("You are Running on Profit only={0}", plannedamount);
            }
            else if (costprice > selledprice)
            {
                plannedamount = costprice - selledprice;
                Console.WriteLine("You are Running on Loss only={0}", plannedamount);
            }
            else
            {
                Console.WriteLine("you are running in no profit and no loss stage");
            }
            Console.ReadLine();

        }
    }
}
