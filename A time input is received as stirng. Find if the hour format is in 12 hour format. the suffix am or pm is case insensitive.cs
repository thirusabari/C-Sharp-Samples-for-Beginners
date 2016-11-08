using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time:");
            string time = Console.ReadLine();
            int i, j, L,Mxtime=12,count=0,s,c1=0;
            string format = string.Empty;
            string start = string.Empty;
            string minutes = string.Empty;
            L = time.Length;
            for (i = 0; i < L; i++)
            {
                if (time[i]==' ')
                {
                    count++;
                }
                else if (count == 1)
                {
                    format = format + time[i];
                }
                else if (time[i] == ':')
                {
                    c1++;
                }
                else if (c1 == 1)
                {
                    minutes = minutes + time[i];
                }
                else if (count == 0)
                {
                    start = start + time[i];
                    
                    
                }

            }
            Console.WriteLine("\n");
            s = Convert.ToInt32(start);
            if (s < Mxtime && (format =="am" || format == "pm"||format=="AM"||format=="PM"))
            {
                Console.WriteLine("true");
            }
            else if (s > Mxtime)
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
