using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String16
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char[] b;char c;
            int i,L;
            Console.WriteLine("Replace LowerCase Letters by UpperCase and Vice Versa");
            Console.WriteLine("Enter the input string");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            for (i = 0; i < L; i++)
            {
                c = b[i];
                if (char.IsLower(c))
                    Console.Write(char.ToUpper(c));
                else
                    Console.Write(char.ToLower(c));
            }
            Console.ReadLine();
        }
    }
}
