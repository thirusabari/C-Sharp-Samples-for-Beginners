using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int count = 0;
            foreach (char A in a)
            {
                count++;
            }
            Console.WriteLine("The Entered String is={0}", a);
            Console.WriteLine("the total no of words in the given string is={0}", count);
            Console.ReadLine();
        }
    }
}
