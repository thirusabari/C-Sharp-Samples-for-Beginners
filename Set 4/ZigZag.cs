using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication213
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZigZag Conversion");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the number of Rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            zigzag(a, rows);
            Console.ReadLine();

        }
        public static void zigzag(string b, int r)
        {
            int i, j;
            int m = r, n = r; string empty = " ";
            string[,] convert = new string[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    convert[i, j] = empty;
                }
            }
            string zag = string.Empty;
            int count = 0;
            char[] d = b.ToCharArray();
            int L = d.Length;
            int[] zig = new int[n];
            int z = 0;
            int e, Quotient, Remainder;
            Quotient = L / r;
            zig[z] = Quotient;
            z++;
            Remainder = L % r;
            zig[z] = Remainder;
            z++;
            zig[z] = r;
            z++;
            string word1 = string.Empty;
            string row1 = string.Empty;
            int count1 = 0; int c2 = 0;
            for (z = 0; z < n; z++)
            {
                if (count1 == n - 1)
                {
                    count = 0;
                    for (e = 0; e < L; e++)
                    {
                        if ( row1 == string.Empty && c2 !=0)
                        {
                            row1 = row1 + d[e];
                            if (word1 != string.Empty)
                            {
                                //count = 0;
                                continue;
                            }
                            else
                            {
                                count++;
                                continue;
                            }
                        }
                        if (z == n - 1 && c2 == 0)
                        {
                            count++;
                            c2++;
                            continue;
                        }
                       
                        count++;
                        if (count == zig[z])
                        {
                            word1 = word1 + d[e];
                            row1 = string.Empty;
                            count = 0;
                            c2 = 0;


                            if (word1.Length == zig[z])
                            {
                                zag = zag + word1;
                                char[] f = word1.ToCharArray();
                                int L1 = f.Length;
                                int g;
                                for (g = 0; g < L1; g++)
                                {

                                    if (g == 0)
                                    {
                                        row1 = row1 + f[g];
                                    }
                                    else
                                    {
                                        row1 = row1 + empty + f[g];
                                    }


                                }
                                Console.WriteLine(row1);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Console.WriteLine(row1);
                    row1 = string.Empty;
                    break;
                }
                else
                {
                    for (e = z; e < L; e++)
                    {
                        if (count == z && row1 == string.Empty && c2 == 0)
                        {
                            row1 = row1 + d[e];
                            zag = zag + d[e];
                            count = 0;
                            continue;
                        }
                        if (z == n - 1 && c2 == 0)
                        {
                            count++;
                            c2++;
                            word1 = word1 + d[e];
                            continue;
                        }
                        count++;
                        word1 = word1 + d[e];

                        if (count == zig[z])
                        {
                            
                            char[] f = word1.ToCharArray();
                            int L1 = f.Length;
                            int g;
                            for (g = 0; g < L1; g++)
                            {
                                if (g == L1 - 1 && zig[z] - 1 == L1 - 1 && count1 == 0)
                                {
                                    zag = zag + f[g];
                                    row1 = row1 + empty + f[g];
                                    count = 0;
                                    word1 = string.Empty;
                                    continue;
                                }
                                else if (g == L1 - 1 && zig[z] - 1 == L1 - 1 && count1 == 1)
                                {
                                    zag = zag + f[g];
                                    row1 = row1 + f[g];
                                    count = 0;
                                    word1 = string.Empty;
                                    continue;
                                }
                              
                            }
                        }
                        else if (e == L - 1)
                        {
                            word1 = string.Empty;
                        }
                    }
                }
                count1++;
              
                Console.WriteLine(row1);
                row1 = string.Empty;

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("THe ZigZag Formatted string is");
            Console.WriteLine(zag);

            Console.ReadLine();

        }
    }
}

