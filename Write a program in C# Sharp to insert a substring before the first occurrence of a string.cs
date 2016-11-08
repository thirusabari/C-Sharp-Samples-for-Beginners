using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String21
{
    class Program
    {
        static void Main(string[] args)
        {

            string str,findstr,Insertstr;
            int i;
            Console.WriteLine("Insert a substring before the first occurence of a string");
            Console.WriteLine("Enter the FirstString");
            str = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the SubString");
            findstr = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Insertstring");
            Insertstr = Console.ReadLine();
            i = str.IndexOf(findstr);
            Insertstr = " " + Insertstr.Trim() + " ";
            str = str.Insert(i, Insertstr);
            Console.WriteLine("The Modified String is={0}", str);
            Console.ReadLine();



        }
    }
}
