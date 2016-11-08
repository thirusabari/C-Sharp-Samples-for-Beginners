using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string ph = Console.ReadLine();
            char[] p = ph.ToCharArray();
            string sp = "-";
            int count = 0;
            string outpt = string.Empty;
            string phneno = string.Empty;
            int i, L,L1,j;
            L = p.Length;
            for (i = 0; i < L; i++)
            {
                if ((int)p[i]>=48&&(int)p[i]<=57)
                {
                    phneno = phneno + p[i];   
                }
                
            }
            Console.WriteLine("\n");
            char[] p1 = phneno.ToCharArray();
            L1 = p1.Length;
            for (j = 0; j < L1; j++)
            {

                if (count == 2||count==3)
                {
                    outpt = outpt + p1[j];
                    if (count == 3)
                    {
                        outpt = outpt + sp;
                    }
                    count++;
                }
                else if (count == 4 || count == 5 || count == 6)
                {
                    outpt = outpt + p1[j] ;
                    if (count == 6)
                    {
                        outpt = outpt + sp;
                    }
                    count++;
                }
                else if (count == 7 || count == 8 || count == 9)
                {
                    outpt = outpt + p1[j];
                    count++;
                }
                else if (count == 0 || count == 1)
                {
                    outpt = outpt+p1[j] ;
                    if (count == 1)
                    {
                        outpt = outpt + sp;
                    }
                    count++;
                }

            }
            Console.WriteLine(outpt);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
