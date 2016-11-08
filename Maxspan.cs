using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication182
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MaxSpan");

            Console.WriteLine("Enter the Maximum Range of the Array:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] a = new int[N];
            Console.WriteLine("Enter the Values:");
            int i, j, k,count=1,v=0,max=0,min=9999,c,count1=0,n=0,m1=0,n1=0,count3=0,dummy=1,count2=0,count4=1;
            string val = string.Empty;
            string[] V = new string[N];
            int[] counts = new int[N];
            string e = string.Empty;
            string f = N.ToString();
            string W = string.Empty;
            string[] jun = new string[N];
            int u = 0,u1,d,z=0,U,C;

            string Y = string.Empty;
        
            if (f.Length == 1)
            {
                count3 = 1;
            }
            else
            {
                char[] r = f.ToCharArray();
                int L1 = r.Length;
                int t;
                for (t = 0; t < L1; t++)
                {
                    count3++;
                }
            }
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                count = 1;
                val = string.Empty;
                W = string.Empty;
                Y = string.Empty;
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (count == 1)
                        {
                            val = val + i.ToString();
                            W = W + i.ToString();
                            Y = Y + W.Length;
                            W = string.Empty;

                            count++;
                        }
                        
                            val = val + j.ToString();
                            W = W + j.ToString();
                            Y = Y + W.Length;
                            W = string.Empty;
                        
                    }
                    
                }
                if (val == string.Empty && W == string.Empty)
                {
                    V[v] = dummy.ToString();
                    v++;
                    jun[u] = dummy.ToString();
                    u++;
                }
                else
                {
                    V[v] = val;
                    v++;
                    jun[u] = Y;
                    u++;

                }
            }
            u1 = u;
            
            Console.WriteLine("\n");
            k = v;
            for (v = 0; v < k; v++)
            {
                char[] b = V[v].ToCharArray();
                int L = b.Length;
                U = z + v;
                count1 = 0; max = 0; min = 9999;
                e = string.Empty;
                for (u = U; u < u1; u++)
                {
                    char[] x = jun[u].ToCharArray();
                    int L2 = x.Length;
                    count2 = 0;
                    if (L2 == 1 && L == 1)
                    {
                        for (c = 0; c < L; c++)
                        {
                            e = e + b[c];
                            if (L2 == e.Length)
                            {
                                count2++;
                                d = Convert.ToInt32(e);
                                e = string.Empty;
                            }
                            else
                            {
                                continue;
                            }
                            if (count2 != 0)
                            {
                                if (d > max)
                                {
                                    max = d;
                                    m1 = max;
                                }
                                if (d < min)
                                {
                                    min = d;
                                    n1 = min;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (i = 0; i < L2; i++)
                        {
                            count4 = 1;
                            C = z + i;
                            for (c = C; c < L; c++)
                            {
                                if (count4 <= x[i])
                                {
                                    e = e + b[c];
                                    
                                }
                                if (count4 == e.Length || ((int)char.GetNumericValue(x[i]) == e.Length))
                                {
                                    if ((int)char.GetNumericValue(x[i]) == e.Length)
                                    {
                                        count2++;
                                        d = Convert.ToInt32(e);
                                        e = string.Empty;
                                        i++;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    if (count2 != 0)
                                    {
                                        if (d > max)
                                        {
                                            max = d;
                                            m1 = max;
                                        }
                                        if (d < min)
                                        {
                                            min = d;
                                            n1 = min;
                                        }
                                    }
                                }
                                else
                                {
                                    count4++;
                                }
                            }
                            j = max;
                            if (min>=0)
                            {
                                i = 0;
                                for (i = min; i <= j; i++)
                                {
                                    count1++;
                                }
                                if (count1 == 0)
                                {
                                    counts[n] = dummy;
                                    n++;
                                }
                                else
                                {
                                    counts[n] = count1;
                                    n++;
                                }
                                
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine("\n");
            k = 0; max = 0;
            k = n;
            for (n = 0; n < k; n++)
            {
                if (counts[n] > max)
                {
                    max = counts[n];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("the maximum counted span is");
            Console.WriteLine("\n");
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
