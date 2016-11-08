using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String14
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char[] b;
            int L, N, i, j,count=0,position,SubStringlen;
            Console.WriteLine("Extract substring from the given string without using Library Function");
            Console.WriteLine("Enter the string");
            a = Console.ReadLine();
            L = a.Length;
            Console.WriteLine("The Length of the Entered String is={0}", L);
            b = a.ToCharArray(0, L);
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Position of SubString Starts:");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Length of the SubString:");
            SubStringlen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("The Extracted SubString is:");
            for (i = position; i < L; i++)
            {
                count++;
                Console.Write("{0}", a[i]);
                if (count == SubStringlen)
                {
                    break;
                    
                }
                
               
            }
            Console.ReadLine();
        }
    }
}
