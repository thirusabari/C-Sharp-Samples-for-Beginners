using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Maximum Limit for Authentication");
            int n = Convert.ToInt16(Console.ReadLine());
            int i;
            int count = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the User Id");
                string userid = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string password = Console.ReadLine();
                count++;
                if (userid=="thiru"&&password=="arasu"&&count!=n)
                {
                    Console.WriteLine("The User  Authentication successfull");
                    break;
                }
                else if(count==n)
                {
                    Console.WriteLine("The User  Authentication failed");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
