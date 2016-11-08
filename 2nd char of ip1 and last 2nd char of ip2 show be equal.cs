using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string b = Console.ReadLine();
            char[] a1 = a.ToCharArray();
            char[] b1 = b.ToCharArray();
            int L1 = a1.Length;
            int L2 = b1.Length;
            int i, j;
            for (i = 0; i < L1; i++)
            {
                for (j = 0; j < L2; j++)
                {
                    if (i == 1 && j == 3)
                    {
                        if ((int)a1[i] >= 65 && (int)a1[i] <= 90)
                        {

                            a1[i] = (char)(a1[i] + 32);
                        }
                        else if ((int)a1[i] >= 97 && (int)a1[i] <= 122)
                        {
                            a1[i] = (char)(a1[i] - 32);
                        }
                        if (a1[i] == b1[j])
                        {
                            Console.WriteLine("true");
                            break;
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
