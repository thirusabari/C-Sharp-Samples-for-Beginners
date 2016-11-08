using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication188
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Values:");
            int N = Convert.ToInt32(Console.ReadLine());
            int n, i, j = 0, count = 0, k = 0, l = 0, m = 0, d = N;
            n = N * N;
            Console.WriteLine("The number of elements to be processed={0}", n);
            int[] a = new int[999];
            int[] b = new int[n];
            int s = 0;
            for (i = 0; i <=n; i++)
            {
                k = k + 1;
                a[j] = k;
                j++;
                
            }
            k = 0;
            int g = 0; g = N; int v = 0; v = j;
            for (l = 0; l < g; l++)
            {
                m = l + count;
                if (count != 0)
                {
                    d = N; d = d+count;
                }
                for (j = count; j <=v; j++)
                {
                    count++;
                    
                    if (j== 0&&l==0)
                    {
                        b[s] = a[j];
                        s++;
                        Console.Write("{0} ", a[j]);
                    }
                    else if (j <= m)
                    {
                        a[j] = a[j] % N;
                        if (a[j] == n||a[j]==0)
                        {
                            a[j] = N;
                            Console.Write("{0} ", a[j]);
                            b[s] = a[j];
                            s++;
                        }
                        else
                        {
                            Console.Write("{0} ", a[j]);
                            b[s] = a[j];
                            s++;
                        }
                    }
                    else
                    {
                        a[j] = 0;
                        Console.Write("{0} ", a[j]);
                        b[s] = a[j];
                        s++;
                    }
                    if (count == d)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
            }
             count = 0;
            for (s = 0; s < n; s++)
            {
                Console.Write("{0} ", b[s]);
            }
            Console.WriteLine("\n");
            int[] c = new int[N];
            string number = string.Empty;
            string n1 = string.Empty;
                for (s = 0; s <n; s++)
                    {
                        count++;
                        number = number + b[s];
                        if (count == N)
                        {
                            char[] t = number.ToCharArray();
                            int u = 0;
                            int L = t.Length;
                            for (u = L - 1; u >= 0; u--)
                            {
                                n1 = n1 + t[u].ToString();
                            }
                            number = string.Empty;
                            count = 0;
                        }
                    }
                Console.WriteLine("\n");
                Console.WriteLine(n1);
                char[] z = n1.ToCharArray();
                int L3 = z.Length;
                int x = 0; count = 0;
                Console.WriteLine("\n");
                Console.WriteLine("The Required Output is:");
                for (x = 0; x < L3; x++)
                {
                    count++;
                    Console.Write("{0} ", z[x]);
                    if (count == N)
                    {
                        Console.WriteLine("\n");
                        count = 0;
                        continue;
                    }
                }
            
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            
            Console.ReadLine();


        }
    }
}
