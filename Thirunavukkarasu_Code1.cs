using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int CalculateSalary;
            Console.WriteLine("Per Day Salary:");
            int daysal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("No of working days:");
            int workdays = Convert.ToInt16(Console.ReadLine());
            //int weeksal = daysal * workdays;
            int[] days = { 31,28,31,30,31,30,31,31,30,31,30,31};
            foreach(int i in days)
            {
                switch(i)    
                {
                        case 31:
                            CalculateSalary = daysal*i;
                            Console.WriteLine(CalculateSalary);
                            break;
                        case 28:
                            CalculateSalary = daysal * i;
                            Console.WriteLine(CalculateSalary);
                            break;
                        case 30:
                            CalculateSalary = daysal * i;
                            Console.WriteLine(CalculateSalary);
                            break;
                    }
                    
            }   
                
                
            Console.ReadKey();

        }
    }
}
