using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Dearness_Allowance, House_Rent_Allowance, Gross_Salary;
            Console.WriteLine("program to Calculate the Gross Salary of an Employee");
            int Basic_Salary = Convert.ToInt32(Console.ReadLine());
            Dearness_Allowance = 0.4 * Basic_Salary;
            House_Rent_Allowance = 0.2 * Basic_Salary;
            Gross_Salary = Basic_Salary- Dearness_Allowance -House_Rent_Allowance;
            Console.WriteLine("The Gross Salary Will be={0}", Gross_Salary);
            Console.ReadLine();
           
        }
    }
}
