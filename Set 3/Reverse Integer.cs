using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication214
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Integer");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number to be processed");
            int N=0,x;
            try
            {
                 N = Convert.ToInt32(Console.ReadLine());
                 x = Range(N);
                 Console.WriteLine("\n");
                 Console.WriteLine("The Reverse string is");
                 Console.WriteLine("\n");
                 if (x == 1)
                 {
                     string a = Convert.ToString(N);
                     char[] b = a.ToCharArray();
                     int L = b.Length;
                     int i;
                     for (i = L - 1; i >= 0; i--)
                     {
                         if ((int)b[i] == 37 || (int)b[i] == 42 || (int)b[i] == 43 || (int)b[i] == 45 || (int)b[i] == 47)
                         {
                             Console.Write(b[i]);
                         }
                     }
                     for (i = L - 1; i >= 0; i--)
                     {
                         if ((int)b[i] >= 48 && (int)b[i] <= 57)
                         {
                             Console.Write(b[i]);
                         }
                     }
                     Console.WriteLine("\n");
                 }
                
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\n");
                Console.WriteLine(e.ToString());
                string a1 = "0";
                Console.WriteLine("\n");
                Console.WriteLine("The Reverse string is");
                Console.WriteLine("\n");
                Console.WriteLine(a1);
                
            }
            
            Console.ReadLine();
        }
        public static int Range(int n)
        {
            int min = -2147483648;
            int max = 2147483647;
            int boolean = (n >= min && n <= max) ? 1 : 0;
            return boolean;
        }
    }
}
