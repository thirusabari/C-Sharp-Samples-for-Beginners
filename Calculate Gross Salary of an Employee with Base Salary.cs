using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Gross Salary of an Employee");
            Console.WriteLine("\n");
            int basesalary = Convert.ToInt32(Console.ReadLine());
            double da, hra, bonus, gs;
            da = (40 * basesalary) / 100;
            Console.WriteLine("da={0}", da);
            Console.WriteLine("\n");
            hra = (80 * da) / 100;
            Console.WriteLine("hra={0}", hra);
            Console.WriteLine("\n");
            bonus = (25 * hra) / 200;
            Console.WriteLine("bonus={0}", bonus);
            Console.WriteLine("\n");
            gs = da + hra + bonus + basesalary;
            Console.WriteLine("The Gross Salary of the Employee is={0}", gs);
            Console.ReadLine();


        }
    }
}
