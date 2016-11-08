using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication160
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            int L = b.Length;
            int i,count=0;
            string makestr= string.Empty;
            string make = string.Empty;
            
            for (i = 0; i < L; i++)
            {
                if ((int)b[i] == 34 || (int)b[i] == 44)
                {
                    count++;
                    continue;
                }
                else if ((int)b[i] == 40)
                {
                    continue;
                }
                else if (count == 1)
                {
                    make = make + b[i];
                }
                else if (count == 4)
                {
                    makestr = makestr + b[i];
                }
            }
            Console.WriteLine("{0}{1}{1}{0}", make, makestr,makestr,make);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
