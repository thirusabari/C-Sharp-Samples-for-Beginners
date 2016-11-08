using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting Number of Occurences of an Character");
            int i, j, N, k = 0, count = 1,l=0,sum=0,C=0,Maximum=0,m=0;
            Console.WriteLine("Enter the Maximum Range of the Array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] search = new int[N];
            int[] freq = new int[N];
            search[k] = -1;
            Console.WriteLine("Enter the input values to the array");
            for (i = 0; i <= N-1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values entered are:");
            for (i = 0; i <= N-1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N-1; i++)
            {
                for (j = 0; j < N-1;j++ )
                {
                    if (a[j] == a[j + 1])
                    {
                        count++;
                        search[k] = a[j];
                        freq[l] = count;

                    }
                    else
                    {
                        search[k] = a[j];
                        freq[l] = count;
                        k++;
                        l++;
                        C++;
                        count = 1;
                        
                    }
                    search[k] = a[j+1];
                    freq[l] = count;
                }
                break;
            }
            Console.WriteLine("To Find the Maximum Occurence of an Character");
            for (l = 0; l <= C;l++)
            {
                for (i = 0; i<= C; i++)
                {
                    if (freq[i] > freq[i + 1])
                    {
                        Maximum = freq[i];
                        m = i;
                    }
                    
                }
                Console.WriteLine("\n");
                Console.WriteLine("Maximum={0}",Maximum);    
                Console.WriteLine("\n");    
                break;
                
            }
            for (k= 0; k <=C; k++)
            {
               for(l=0;l<=C;l++)
                {
                    if (k == l)
                    {
                        Console.WriteLine("The Given character {0} appears {1} times", search[k], freq[l]);
                        
                    }
                   if (k == l&&k==m)
                    {
                        Console.WriteLine("The given character {0} appears  Maximum of {1} times", search[k], freq[l]);
                        break;
                    }
                   
                    
                }
               if (sum == N)
               {
                   break;
               }
            }

            Console.ReadLine();
            
        }
    }
}
