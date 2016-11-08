using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic6
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("The entered Character is an Lowercase Vowel={0}", c);
            }
            else if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            {
                Console.WriteLine("The entered character is an Digit={0}", c);

            }
            else
                Console.WriteLine("The Entered Character doesnot contains  any vowels and digits");
            Console.ReadLine();
        }
    }
}
