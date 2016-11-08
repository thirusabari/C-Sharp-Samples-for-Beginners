using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the string:");
            string a = Console.ReadLine();
            int i,L,s=0,n=0,C=0;
            L = a.Length;
            for (i = 0; i < L; i++)
            {
                if (((char)a[i] >= 0 && (char)a[i] <= 47) || ((char)a[i] >= 58 && (char)a[i] <= 64) || ((char)a[i] >= 91 && (char)a[i] <= 96) || ((char)a[i] >= 123 && (char)a[i] <= 127))
                {
                    s++;
                }
                else if ((char)a[i] >= 48 && (char)a[i] <= 57)
                {
                    n++;
                }
                else if (((char)a[i] >= 65 && (char)a[i] <= 90) || ((char)a[i] >= 97 && (char)a[i] <= 122))
                {
                    C++;
                }
            }
            Console.WriteLine("The Maximum Numbers in the given string is={0}", n);
            Console.WriteLine("\n");
            Console.WriteLine("The maximum Characters in the given string is={0}", C);
            Console.WriteLine("\n");
            Console.WriteLine("The Maximum Special Characters in the given string is={0}", s);
            Console.ReadLine();
            
        }
    }
}
