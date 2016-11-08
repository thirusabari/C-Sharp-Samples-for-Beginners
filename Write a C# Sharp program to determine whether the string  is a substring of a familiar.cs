using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String25
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, substr;
            bool x; int index;
            Console.WriteLine("Find the Substring in the given string and its position too");
            Console.WriteLine("Enter the first string");
            a = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Second String");
            substr = Console.ReadLine();
            x = a.Contains(substr);
            Console.WriteLine("the string {0} contains substring {1} ={2}", a, substr, x);
            if (x)
            {
                index = a.IndexOf(substr);
                Console.WriteLine("the substring {0}  located at {1} position", substr, index);
            }
            Console.ReadLine();
        }
    }
}
