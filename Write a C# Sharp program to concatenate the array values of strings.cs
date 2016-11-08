using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = {"hai","hello","welocme","MR.","Sigaram","Thank you","Very Much","Please" };
            Console.WriteLine("{0} ",string.Concat(a));
            Array.Sort(a);
            Console.WriteLine("\n");
            Console.WriteLine("{0} ",string.Concat(a));
            Console.ReadLine();
        }
    }
}
