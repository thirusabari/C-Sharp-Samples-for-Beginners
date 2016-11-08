using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest Calculation");
            Console.WriteLine("Enter the Principal Amount");
            int PrincipalAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Rate of Interest");
            int Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the time taken");
            int Time = Convert.ToInt32(Console.ReadLine());
            double simpleInterest = (PrincipalAmount * Rate * Time) / 100;
            Console.WriteLine("The simple Interest is={0}", simpleInterest);
            Console.ReadLine();
        }
    }
}
