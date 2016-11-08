using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_for_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            int a, b, c, d;
            for(int palindrome=100;palindrome<=n;palindrome++)
    {
             a = palindrome % 10;
                b = palindrome / 10;
                c = b % 10;
                d = b / 10;
                sum = 0;
                int[] palindorme1 = { a, c, d };
                    foreach(int i in palindorme1)
                    {
                        sum = sum * 10 + i;
                    }
                    if (palindrome == sum)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("the given number {0} is an palindrome={1}", palindrome, sum);
                    }
                    }       
            Console.ReadLine();
    
}
    }
}
