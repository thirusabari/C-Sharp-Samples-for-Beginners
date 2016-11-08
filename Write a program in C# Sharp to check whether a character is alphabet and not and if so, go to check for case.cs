using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String19
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Check the whether the character is an alphabet or not and check the case also");
            ch = (char)Console.Read();
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    Console.WriteLine("The entered character is an uppercase ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("THe entered character is an lowercase");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("the entered character is not an alphabetic character");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
