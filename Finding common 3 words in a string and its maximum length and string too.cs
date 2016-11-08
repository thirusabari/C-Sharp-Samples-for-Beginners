using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String splitup without auiltin functions");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the string:");
            string A1 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Second String:");
            string A2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the third string:");
            string A3 = Console.ReadLine();
            int i,j,k, c1=0,c2=0,c3=0,L1,L2,L3,len1=0,len2=0,len3=0;
            string a = string.Empty;
            string b = string.Empty;
            string c = string.Empty;
            string d = string.Empty;
            string e = string.Empty;
            string f = string.Empty;
            string g = string.Empty;
            string h = string.Empty;
            string I = string.Empty;
            string O1 = string.Empty;
            string O2 = string.Empty;
            string O3 = string.Empty;
            L1 = A1.Length;
            L2 = A2.Length;
            L3 = A3.Length;
            for (i = 0; i < L1; i++)
            {
                if (A1[i] == ' ')
                {
                    c1++;
                    continue;
                }
                if (c1 == 1)
                {
                    b = b + A1[i];
                }
                else if (c1 == 2)
                {
                    c = c + A1[i];
                }
                else
                {
                    a = a + A1[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The given String is={0}", A1);
            Console.WriteLine("\n");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("\n");
            for (j = 0; j < L2; j++)
            {
                if (A2[j] == ' ')
                {
                    c2++;
                    continue;
                }
                if (c2 == 1)
                {
                    e = e + A2[j];
                }
                else if (c2 == 2)
                {
                    f = f + A2[j];
                }
                else
                {
                    d = d + A2[j];
                }
            }
            Console.WriteLine("The Second String is={0}", A2);
            Console.WriteLine("\n");
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine("\n");
            for (k = 0; k < L3; k++)
            {
                if (A3[k] == ' ')
                {
                    c3++;     
                    continue;
                }
                else if (c3 == 1)
                {
                    h = h + A3[k];
                }
                else if (c3 == 2)
                {
                    I = I + A3[k];
                }
                else
                {
                    g = g + A3[k];
                }
            }
            Console.WriteLine("The third string is={0}",A3);
            Console.WriteLine("\n");
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(I);
            string[] B1 = { a, d, g };
            string[] B2 = { b, e, h };
            string[] B3 = { c, f, I };
            c1 = 0;
            c2 = 0;
            c3 = 0;
            for (i = 0; i < B1.Length-1; i++)
            {
                if (B1[i] == B1[i + 1])
                {
                    c1++;
                    if (c1 == 2)
                    {
                        len1 = B1[i+1].Length;
                        O1 = B1[i + 1];
                    }
                }
            }
            if (len1 != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("len1={0}", len1);
                Console.WriteLine("\n");
                Console.WriteLine("The string is={0}", O1);
            }
            for (j = 0; j < B2.Length-1; j++)
            {
                if (B2[j] == B2[j + 1])
                {
                    c2++;
                    if (c2 == 2)
                    {
                        len2 = B2[j + 1].Length;
                        O2 = B2[j + 1];
                    }
                }
            }
            if (len2 != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("len2={0}", len2);
                Console.WriteLine("\n");
                Console.WriteLine("The string is={0}", O2);
            }
            for (k = 0; k < B3.Length - 1; k++)
            {
                if (B3[k] == B3[k + 1])
                {
                    c3++;
                    if (c3 == 2)
                    {
                        len3 = B3[k + 1].Length;
                        O3 = B3[k + 1];
                    }
                }
            }
            if (len3 != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("len3={0}", len3);
                Console.WriteLine("\n");
                Console.WriteLine("The string is={0}", O3);
            }
            int[] length = { len1, len2, len3 };
            string[] names = { O1, O2, O3 };
            int MaximumLength = 0;
            for (i = 0; i < length.Length; i++)
            {
                if (length[i] > MaximumLength)
                {
                    MaximumLength = length[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The entered strings are:");
            Console.WriteLine("\n");
            Console.WriteLine(A1);
            Console.WriteLine(A2);
            Console.WriteLine(A3);
            for (j = 0; j < names.Length; j++)
            {
                if (MaximumLength == names[j].Length)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("The Maximum Length={0}", MaximumLength);
                    Console.WriteLine("\n");
                    Console.WriteLine("The Maximum Length Containing string is={0}", names[j]);

                }
            }
            Console.ReadLine();
            
        }
    }
}
