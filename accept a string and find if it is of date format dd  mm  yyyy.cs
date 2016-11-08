using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string date = Console.ReadLine();
            char[] d = date.ToCharArray();
            int i,L,count=0,month,dat;
            L = d.Length;
            string D = string.Empty;
            string M = string.Empty;
            string Y = string.Empty;
            for (i = 0; i < L; i++)
            {
                if (d[i] == '/')
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    M = M + d[i];
                }
                else if (count == 2)
                {
                    Y = Y + d[i];
                }
                else if(count==0)
                {
                    D = D + d[i];
                }
            }
            month = Convert.ToInt32(M);
            dat = Convert.ToInt32(D);
            Console.WriteLine("\n");
            if (month <= 12 && (dat <= 31 || dat <= 30) && D.Length == 2 && M.Length == 2 && Y.Length == 4)
            {
                Console.WriteLine("The given string is in Correct Format of DD/MM/YYYY");
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("The Given string is not in Correct Format DD/MM/YYYY");
                Console.WriteLine("false");
            }
            Console.ReadLine();

        }
    }
}
