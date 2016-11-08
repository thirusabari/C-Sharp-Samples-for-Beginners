using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  first Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            string sum = string.Empty;
            string b = string.Empty;
            int i,  rem,a,logic=0,j;
            for (i = n1; i <= n2; i++)
            {
                a = i;
                sum = string.Empty;
                while (a != 0)
                {
                    rem = a % 10;
                    sum = sum + rem;
                    a = a / 10;
                    
                }
                
                if (sum == Convert.ToString(i))
                {
                    logic = logic + Convert.ToInt32(sum);
                    sum = string.Empty;
                    rem = 0;
                    
                }
                
            }
            Console.WriteLine("The sum of 2 intervals palindrome numbers are={0}", logic);
            Console.ReadLine();
        }
    }
}
