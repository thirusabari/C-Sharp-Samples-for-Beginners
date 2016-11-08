using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today:" + DateTime.Now);
            TimeSpan Duration = new TimeSpan(40, 0, 0, 0);
            DateTime Answer = today.Add(Duration);
            Console.WriteLine("{0:dddd}", Answer);
            Console.ReadLine();
        }
    }
}
