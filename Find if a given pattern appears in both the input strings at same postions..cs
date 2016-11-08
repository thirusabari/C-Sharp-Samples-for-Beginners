using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication112
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, L1,L2,c1=0,c2=0,p=0,k=0,p1=0;
            
            Console.WriteLine("Enter the First String");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            string b = Console.ReadLine();
            L1 = a.Length;
            L2 = b.Length;
            int[] pos = new int[10];
            int[] pos1 = new int[10];
            for (i = 0; i < L1; i++)
            {
                if (a[i] == '-')
                {
                    pos[p] = i;
                    p++;
                    c1++;
                }
            }
            for (j = 0; j < L2; j++)
            {
                if (b[j] == '-')
                {
                    pos1[p1] = j;
                    p1++;
                    c2++;
                }
            }
            for (p = 0; p < c1; p++)
            {
                for (p1 = 0; p1 < c2; p1++)
                {
                    if (pos[p] == pos1[p1])
                    {
                        k = k + 2;
                        Console.WriteLine("{0}==={1}", pos[p], pos1[p1]);
                    }
                }
            }
            
            Console.WriteLine("\n");
            if (k == (c1 + c2))
            {
                Console.WriteLine("true");
            }
            Console.ReadLine();

        }
    }
}
