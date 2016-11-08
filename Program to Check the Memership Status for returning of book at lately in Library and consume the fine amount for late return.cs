using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            int b = 1, c = 5; double a = 0.50; double fine,f;
            Console.WriteLine("Library Program for late returning of book");
            days = Convert.ToInt32(Console.ReadLine());
            if (days > 30)
            {
                Console.WriteLine("Your Membership was Cancelled");
                
            }
            else if (days > 10 && days <= 30)
            {
                f = days - 10;
                fine = (f * c) + a + b;
                Console.WriteLine("For the Late Return your fine amount charged as={0}", fine);
                

            }
            else if (days > 5 && days <= 10)
            {
                fine = a + b;
                Console.WriteLine("The fine Amount is={0}", fine);
            }
            else if (days <= 5 && days > 0)
            {
                fine = a;
                Console.WriteLine("the fine amount is={0}", fine);
            }
            Console.ReadLine();
        }
    }
}
