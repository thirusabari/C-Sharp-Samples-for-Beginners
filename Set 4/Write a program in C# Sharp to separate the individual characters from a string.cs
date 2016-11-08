using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            foreach (char A in a)
            {
                Console.Write("{0} ", A);
            }
            Console.ReadLine();
        }
    }
}
