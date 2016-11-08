using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic22
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'a' || grade == 'A')
            {
                Console.WriteLine("{0}=Average", grade);
            }
            else if (grade == 'f' || grade == 'F')
            {
                Console.WriteLine("{0}=Fail", grade);
            }
            else if (grade == 'g' || grade == 'G')
            {
                Console.WriteLine("{0}=Good", grade);
            }
            else if (grade == 'v' || grade == 'V')
            {
                Console.WriteLine("{0}=Very Good", grade);
            }
            else if (grade == 'e' || grade == 'E')
            {
                Console.WriteLine("{0}=Excellant", grade);
            }
            else
            {
                Console.WriteLine("Nothing to Show");
            }
            Console.ReadLine();
        }
    }
}
