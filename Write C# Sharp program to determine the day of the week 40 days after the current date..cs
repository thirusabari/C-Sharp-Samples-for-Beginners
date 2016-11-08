using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Today = DateTime.Now;
            DateTime Answer = Today.AddDays(40);
            Console.WriteLine("Today:{0:dddd}" , Today);
            Console.WriteLine("40 days from today:{0:dddd}", Answer);
            Console.ReadLine();
        }
    }
}
