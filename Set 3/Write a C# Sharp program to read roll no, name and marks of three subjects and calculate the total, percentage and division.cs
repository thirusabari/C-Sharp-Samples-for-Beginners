using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic15
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollno,physics,chemistry,computerApplication;
            string name;
            rollno = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            physics = Convert.ToInt32(Console.ReadLine());
            chemistry = Convert.ToInt32(Console.ReadLine());
            computerApplication = Convert.ToInt32(Console.ReadLine());
            int total;
            float percentage;
            total = physics + chemistry + computerApplication;
            percentage = total / 3;
            Console.WriteLine("The Student Details are");
            Console.WriteLine("The Rollnumber={0}", rollno);
            Console.WriteLine("The Student name={0}", name);
            Console.WriteLine("Physics marks={0}", physics);
            Console.WriteLine("The Chemistry marks={0}", chemistry);
            Console.WriteLine("The ComputerApplication={0}", computerApplication);
            Console.WriteLine("The total value={0}", total);
            Console.WriteLine("The Percentage={0}", percentage + "%");
           
            if (percentage >= 80)
            {
                Console.WriteLine("First Class");
            }
            else if (percentage >= 65 && percentage < 80)
            {
                Console.WriteLine("Second Class");
            }
            else
            {
                Console.WriteLine("Third Class");
            }
            Console.ReadLine();
        }
    }
}
