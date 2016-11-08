using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ConsoleApplication105
{
    class Program
    {
        static NameValueCollection GetKey()
        {
            NameValueCollection Average = new NameValueCollection();
            Average.Add("12", "90");
            Average.Add("33", "90");
            Average.Add("35", "90");
            Average.Add("56", "88");
            return Average;
        }

        static void Main()
        {

            int i, j,o=0, N, L,k=0, count = 0, av, c1 = 0, c2 = 0, Sum = 0, Average1,c3=0;
            NameValueCollection Average = GetKey();
            Console.WriteLine("Enter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] keys = new int[N];
            int[] oddpos = new int[N];
            string v = string.Empty;
            string[] a = new string[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();
            }
            foreach (string key in Average)
            {
                keys[k] = Convert.ToInt32(key);
                k++;
                
            }
            for (k = 0; k <keys.Length; k++)
            {
                if (keys[k] % 2 == 1)
                {
                    oddpos[o] = keys[k];
                    o++;
                    c3++;
                    Console.WriteLine("\n");
                    Console.WriteLine("The Odd Key Values are={0}", keys[k]);
                }
            }
            
            for (i = 0; i < N; i++)
            {
                for (o = 0; o < c3; o++)
                {
                    if (a[i].Contains(oddpos[o].ToString()))
                    {
                        char[] b = a[i].ToCharArray();
                        L = b.Length;
                        c1 = 0;
                        v = string.Empty;
                        for (j = 0; j < L; j++)
                        {
                            if (b[j] == ':')
                            {
                                count++;
                                continue;
                            }
                            if (count == 1)
                            {
                                v = v + b[j];
                                c1++;
                                if (c1 == 2)
                                {
                                    av = Convert.ToInt32(v);
                                    
                                        c2++;
                                        Sum = Sum + av;
                                        c1 = 0;

                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
             Average1 = Sum / c2;
             Console.WriteLine("\n");
             Console.WriteLine(Average1);
            Console.ReadLine();
        }
    }
}
