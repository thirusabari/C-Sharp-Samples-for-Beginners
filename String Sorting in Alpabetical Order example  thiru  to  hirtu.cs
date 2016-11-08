using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, L; char[] b; char temp;
            Console.WriteLine("String sorting");
            string a;
            Console.WriteLine("Enter the string");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            for (i = 0; i < L; i++)
            {
                Console.Write("{0} ",b[i]);
            }
            Console.WriteLine("\n");
            for (i = 1; i <= L; i++)
            {
                for (j = 0; j < L - 1; j++)
                {
                    if ((int)b[j] > (int)b[j + 1])
                    {
                        temp = b[j];
                        b[j] = b[j + 1];
                        b[j+1] = temp;

                    }
                }
            }
            Console.WriteLine("\n");
            for (i = 0; i < L; i++)
            {
                Console.Write("{0} ",b[i]);
            }
            Console.ReadLine();
        }
    }
}
