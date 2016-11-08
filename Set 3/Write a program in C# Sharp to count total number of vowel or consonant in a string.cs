using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int i = 0; int L, vowels = 0, consonants = 0;
            Console.WriteLine("Count the number of vowels and consonants in a string");
            Console.WriteLine("Enter the First String:");
            a = Console.ReadLine();
            L = a.Length;
            while(i < L)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
                i++;
            }
            Console.WriteLine("The given string contains the vowels are={0}", vowels);
            Console.WriteLine("THe Given string contains the Consonants are={0}", consonants);
            Console.ReadLine();
        }
    }
}
