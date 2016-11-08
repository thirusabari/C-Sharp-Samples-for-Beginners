using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String101
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();

            int i, j, L1, l; string ab = string.Empty;
            string[] c1 = a1.Split(' ');
            L1 = c1.Length;
            Console.WriteLine("\n");
            Console.WriteLine("The first string is");
           foreach(string c in c1)
            {
                Console.WriteLine(c);
            }
           Console.WriteLine("\n");
           Console.WriteLine("Focus on Each word First Letter");
           foreach(string c in c1)
           {
               l = c.Length;  
               for (j = 0; j<=0;j++)
               {
                   if (j == 0)
                   {
                       ab = ab+c[j];
                   }
                   else
                   {
                       break;
                   }
               }
               
           }
           Console.WriteLine(ab);
           
            Console.ReadLine();
                       
           


        }
    }
}
