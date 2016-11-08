using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int alphabets, digits, specialCharacter, i,l;
                alphabets = digits = specialCharacter = i = 0;
                Console.WriteLine("Count the number of digits,alpabets,special characters in a string");
                Console.WriteLine("Enter the input String");
                a = Console.ReadLine();
                l = a.Length;
                while (i < l)
                {
                    if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                    {
                        alphabets++;
                    }
                    else if (a[i] >= '0' && a[i] <='9')
                    {
                        digits++;
                    }
                    else
                    {
                        specialCharacter++;
                    }
                    i++;
                }
                Console.WriteLine("The Number of Alphabets in a String is={0}", alphabets);
                Console.WriteLine("The Number of Digits in a String is={0}", digits);
                Console.WriteLine("The number of special Characters in  a string is={0}", specialCharacter);
                Console.ReadLine();
            

        }
    }
}
