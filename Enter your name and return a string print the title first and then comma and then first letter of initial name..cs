using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            char[] na = name.ToCharArray();
            int i, L,count=0;
            string NAME = string.Empty;
            L = na.Length;
            for (i = 0; i < L; i++)
            {
                if (na[i] == ' ')
                {
                    na[i] = ',';
                    NAME = NAME + na[i];
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    NAME = NAME + na[i];
                    break;
                }
                else if(count==0)
                {
                    NAME = NAME + na[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(NAME);
            Console.ReadLine();
        }
    }
}
