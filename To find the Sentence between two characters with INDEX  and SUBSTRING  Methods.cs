using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConversion38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Find Sentence Between two Characters");
            string a = Console.ReadLine();
            int start = a.IndexOf("a");
            int end = a.IndexOf("h");
            Console.WriteLine("{0}={1}", start, end);
            Console.WriteLine(a.Substring(start+1, end));
            Console.ReadLine();
        }
    }
}
