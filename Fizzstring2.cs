using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication176
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzString2");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            string special = "!";
            string word = "Fizz";
            string word1 = "Buzz";
            string word2 = "FizzBuzz";
            string number = string.Empty;
            int three = 0, five = 0;
            if (n % 3 == 0)
            {
                three++;
            }
            if (n % 5 == 0)
            {
                five++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            if (three == 1 && five == 0)
            {
                word = word+ special;
                Console.WriteLine("\n");
                Console.WriteLine(word);
  

            }
            else if (three == 0 && five == 1)
            {
                word1 = word1 + special;
                Console.WriteLine("\n");
                Console.WriteLine(word1);
            }
             else if (three == 1 && five == 1)
            {
                word2 = word2 + special;
                Console.WriteLine("\n");
                Console.WriteLine(word2);
            }
            else
            {
                number = number + n.ToString() + special;
                Console.WriteLine("\n");
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
