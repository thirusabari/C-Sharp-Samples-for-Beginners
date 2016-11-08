using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int len = 0;
            foreach(char A in a)
            {
                len += 1;
            }
            Console.WriteLine("The entered String is:={0}",a) ;
            Console.WriteLine("The Length of the String is={0}", len);
            Console.ReadLine();
        }
    }
}
