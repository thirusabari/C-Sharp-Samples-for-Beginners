using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication197
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LoneSum");
            Console.WriteLine("Enter the Maximum Range for the array:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            Console.WriteLine("Enter the values for the array:");
            int i, j,p=0,sum=0,count=0,count1=0,c2=0;
            int[] pos = new int[10];
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                for (j = i+1; j < N; j++)
                {
                    if (a[i] == a[j]&&count==0)
                    {
                        count++;
                        pos[p] = i;
                        p++;
                        pos[p] = j;
                        p++;
                        c2++;
                        continue;
                    }
                   else if (count == 1)
                    {
                        pos[p] = j;
                        p++;
                        c2++;
                    }
                    
                }
                break;                
            }
            j=0;j=p;
            if (p != 0)
            {
                for (p = 0; p < j; p++)
                {
                    Console.Write("{0} ", pos[p]);
                }
                Console.WriteLine("\n");
                c2 = 0;
                for (i = c2; i < N; i++)
                {
                    for (p = c2; p < j; p++)
                    {
                        if (i != pos[p])
                        {
                            sum = sum + a[i];
                            c2++;
                            break;

                        }
                        else
                        {
                            c2++;
                            break;
                        }
                    }
                }
            }
            else if (p == 0)
            {
                for (i = 0; i < N; i++)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(sum);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
