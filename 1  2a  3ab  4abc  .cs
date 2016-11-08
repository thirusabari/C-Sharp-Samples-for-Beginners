using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, s = 1; 
            Console.WriteLine("Number of rows");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(s);
                        s++;
                    }
                    else
                    {
                            Console.WriteLine((char)('a'+ (j - 1)));
                       
                       
                }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
