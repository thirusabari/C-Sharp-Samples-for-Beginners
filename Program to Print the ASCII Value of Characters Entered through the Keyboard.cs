using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Print the ASCII Value of the Characters Entered through the Keyboard");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine((int)c);
            Console.ReadLine();
        }
    }
}
