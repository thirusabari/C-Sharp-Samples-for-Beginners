using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a; string b = string.Empty;
            int i;
            Console.WriteLine("Copy one String into Another String without using Builtin Function");
            Console.WriteLine("ENter the first String");
            a = Console.ReadLine();
            for (i = 0; i < a.Length; i++)
            {
                b = b + a[i];
            }
            Console.WriteLine("The string b is={0}", b);
            Console.ReadLine();

        }
    }
}
