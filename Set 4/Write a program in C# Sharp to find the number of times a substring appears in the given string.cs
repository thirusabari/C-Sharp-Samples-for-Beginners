using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String20
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, Substr;
            int index=0;
            int count=-1,c=-1;
            Console.WriteLine("Find the times of occurences of substring in a string:");
            Console.WriteLine("ENter the string");
            a = Console.ReadLine();
            Console.WriteLine("ENter the Substring");
            Substr = Console.ReadLine();
            while (index != -1)
            {
                index = a.IndexOf(Substr, count+1);
                c = c + 1;
                count = index;
            }
            Console.WriteLine("The given string {0} and {1} times", Substr, c);
            Console.ReadLine();
        }
    }
}
