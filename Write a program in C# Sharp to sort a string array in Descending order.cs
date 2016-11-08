using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            char[] b; char temp;
            int i, j,L;
            Console.WriteLine("Sorting the String Array in Descending Order");
            Console.WriteLine("Enter the String:");
            a = Console.ReadLine();
            L = a.Length;
            b = a.ToCharArray(0, L);
            for (i = 1; i < L; i++)
            {
                for (j = 0; j < L - i; j++)
                {
                    if (b[j] < b[j + 1])
                    {
                        temp = b[j];
                        b[j]=b[j+1];
                        b[j + 1] = temp;
                        
                    }

                }
            }
            Console.WriteLine("After the Sorting of Descending Order");
            foreach (char t in b)
            {
                temp = t;
                Console.Write("{0} ", temp);
            }
            Console.ReadLine();


        }
    }
}
