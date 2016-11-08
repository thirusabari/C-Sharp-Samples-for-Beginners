using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int maximum = 0, i = 0, L;
            Console.WriteLine("Program to Find the Maximum Occurence of an Character in the Given String");
            Console.WriteLine("Enter the String");
            a = Console.ReadLine();
            L = a.Length;
            while (i < L)
            {
                if (a[i] == 'e')
                {
                    maximum++;
                }
                
                i++;
            }
            Console.WriteLine("The Character appears times:{0}",maximum);
            Console.ReadLine();
        }
    }
}
