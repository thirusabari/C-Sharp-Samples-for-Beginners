using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication127
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the IP Address");
            string IP = Console.ReadLine();
            int i, j=0,L;
            char[] ipa = IP.ToCharArray();
            L = ipa.Length;
            for (i = 0; i < L; i++)
            {
                if (ipa[i] == '.')
                {
                    
                    continue;
                }
                else 
                {
                    if ((int)ipa[i] >= 0 && (int)ipa[i] <= 127)
                    {
                        j++;
                    }

                }
            }
            if (j == 4)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("1");

            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
    }
}
