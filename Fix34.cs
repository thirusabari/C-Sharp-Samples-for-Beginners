using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication184
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range for the Array:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int[] a = new int[N];
            int[] fours = new int[N];
            int[] threes = new int[N];
            int[] diff = new int[N];
            int pos1 = 0, pos2 = 0;
            string indexes = string.Empty;
            string I = string.Empty;
            string[] values = new string[N];
            string F = string.Empty; string D = string.Empty;
            int i, j=0, k,count=0,f=0,pos=0,t=0,d=0,X=0,v=0;
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Values for the Array:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("The Input Values Entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                if (a[i] == 3)
                {
                    threes[t] = i;
                    t++;
                }
                if (a[i] == 4)
                {
                    fours[f] = i;
                    f++;
                }

            }
            j = t;
            k = f;
            
            Console.WriteLine("\n");
            for (t = 0; t < j; t++)
            {
                for (f = 0; f < k; f++)
                {
                    if (t == f)
                    {
                        if (threes[t] > fours[f]&&threes[t]<N)
                        {
                            pos= threes[t]+1;
                            diff[d] = pos;
                            d++;
                            pos = 0;
                        }
                        if (threes[t] < fours[f])
                        {
                            if (threes[t] != 0)
                            {
                                pos = threes[t]+ 1;
                            }
                            else
                            {
                                pos = 1;
                            }
                            diff[d] = pos;
                            d++;
                            pos = 0;
                        }
                    }
                }
            }
            j = 0;
            j = d; k = 0; k = f;
            for (f = 0; f < k; f++)
            {
                for (d = 0; d < j; d++)
                {
                    if (f == d)
                    {
                        if (fours[f] > diff[d])
                        {
                            F = fours[f].ToString();
                            D = diff[d].ToString();
                            I = (D.Length).ToString() + (F.Length).ToString();
                            Console.WriteLine(I);
                            values[v] = I;
                            v++;
                            indexes = indexes + diff[d].ToString() + fours[f].ToString();
                            Console.WriteLine(indexes);
                            F = string.Empty; D = string.Empty; I = string.Empty;
                        }
                        if (fours[f] < diff[d])
                        {
                            F = fours[f].ToString();
                            D = diff[d].ToString();
                            I = (F.Length).ToString() + (D.Length).ToString();
                            Console.WriteLine(I);
                            values[v] = I;
                            v++;
                            indexes = indexes + fours[f].ToString() + diff[d].ToString();
                            Console.WriteLine(indexes);
                            F = string.Empty; D = string.Empty; I = string.Empty;
                        }
                    }
                }
            }
          k=v; j = 0;

            char[] ix = indexes.ToCharArray();
            int x, L1 = ix.Length;
            string number = string.Empty;
            Console.WriteLine("\n");
            
                for (v = 0; v < k; v++)
                {
                    char[] v1 = values[v].ToCharArray();
                    int u, L2 = v1.Length;
                    if (count != 0)
                    {
                        j = count;
                    }
                    count = 0; pos1 = 0; pos2 = 0;
                    for (u = 0; u < L2; u++)
                    {
                        X = j + u;
                        for (x =X; x < L1; x++)                           //I  have too swap the values
                        {                                                 //in v1[0]=11  and ix[x]=34
                                
                                number = number + ix[x];
                                if (number.Length == (int)char.GetNumericValue(v1[u]) && count == 0)
                                {
                                    pos1 = Convert.ToInt32(number);
                                    number = string.Empty;
                                    count++;
                                    break;
                                }
                                else if (number.Length == (int)char.GetNumericValue(v1[u]) && count >= 1)
                                {
                                    pos2 = Convert.ToInt32(number);
                                    number = string.Empty;
                                    count++;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                        }
                    }
                    for (i = 0; i < N; i++)
                    {
                    int temp = 0;
                    temp = a[pos1];
                    a[pos1] = a[pos2];
                    a[pos2] = temp;
                    break;
                }
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
