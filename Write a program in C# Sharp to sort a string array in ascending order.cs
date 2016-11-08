using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String11
{
    class Program
    {
        static void Main(string[] args)
        {
            string a; char[] b;
            int i,j,L;
            char temp;
            Console.WriteLine("Program to sort an String in Ascending Order");
            Console.WriteLine("Enter the String");
            a = Console.ReadLine();
            L=a.Length;
            b = a.ToCharArray(0, L);
            for (i = 1; i < L; i++)
            {
                for (j = 0; j < L-1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        temp = b[j];
                        b[j] = b[j + 1];
                        b[j+1] = temp;
                    }
                }
            }
            
            Console.WriteLine("After sorting");
            foreach(char t in b)
            {
                temp=t;
                Console.Write("{0} ",t);
            }

            Console.ReadLine();
        }
    }
}
