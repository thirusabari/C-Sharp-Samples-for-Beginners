using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the Second String:");
            string b = Console.ReadLine();
            string a1 = string.Empty;
            string b1 = string.Empty;
            string n1 = string.Empty;
            string n2 = string.Empty;
            int i, j, k,L1,L2,num1=0,num2=0,c1=0,c2=0,maxmarks=0;
            L1 = a.Length;
            L2 = b.Length;
            for (i = 0; i < L1; i++)
            {
                if (a[i] >= 48 && a[i] <= 57)
                {
                    a1 = a1 + a[i];
                }
            }
            for (j = 0; j < L2; j++)
            {
                if (b[j] >= 48 && b[j] <= 57)
                {
                    b1 = b1 + b[j];
                }
            }
            for (i = 0; i < a1.Length; i++)
            {
                c1++;
                n1 = n1 + a1[i];
                if (c1 == 2)
                {
                    num1 = num1 + Convert.ToInt32(n1);
                    c1 = 0;
                    n1 = string.Empty;
                    continue;
                }
            }
            for (j = 0; j < b1.Length; j++)
            {
                c2++;
                n2 = n2 + b1[j];
                if (c2 == 2)
                {
                    num2 = num2 + Convert.ToInt32(n2);
                    c2 = 0;
                    n2 = string.Empty;
                    continue;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            if (num1 > num2)
            {
                maxmarks = num1;
                for (i = 0; i < L1; i++)
                {
                    if (a[i] >= 97 && a[i] <= 122)
                    {
                        Console.Write(a[i]);
                    }
                }
            }
            else if (num2 > num1)
            {
                maxmarks = num2;
                for (j = 0; j < L2; j++)
                {
                    if (b[j] >= 97 && b[j] <= 122)
                    {
                        Console.Write(b[j]);
                    }
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();


        }
    }
}
