using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_for_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a =Console.ReadLine();
            int i;
            for ( i = a.Length-1; i >=0; i--)
            {
                     Console.WriteLine("The Reverse string is={0}",a[i]);
            }
            Console.ReadKey();
             }

    }
}
