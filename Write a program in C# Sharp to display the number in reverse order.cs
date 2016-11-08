using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping29
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0,rem;
            Console.WriteLine("Number Reverse");
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number != 0)
            {
                rem = number % 10;
                sum = sum * 10 + rem;
                number = number / 10;
            }
            
            Console.WriteLine("The Reversed number is={0}", sum);
            
            Console.ReadLine();
        }
    }
}
