using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Maximum Frequency of character entered");
            int i, j, k=0, l=0, N, Maximum = 0, m = 0, count = 1, C = 0;
            Console.WriteLine("Enter the Maximum range of series entered");
            N = Convert.ToInt32(Console.ReadLine());
            char[] a = new char[N];
            char[] search = new char[N];
            int[] freq = new int[N];
            Console.WriteLine("Enter the input values:");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("The Input Characters are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("To Find the Maximum Frequency");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N-1; j++)
                {
                    if (a[j] ==a[j + 1])
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
                    search[k] = a[j + 1];
                    freq[l] = count;
                }
                break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("To Find the Maximum Occurence of an Character");
            for (k = 0; k <= C; k++)
            {
                for (l = 0; l <= C; l++)
                {
                    if (freq[l] > freq[l + 1])
                    {
                        Maximum = freq[l];
                        m = l;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("The Maximum Appearance is={0}", Maximum);
                Console.WriteLine("\n");
                break;
            }
            Console.WriteLine("To Print the Each Character Frequency and Maximum Freqeuncy of the character");
            for (k = 0; k <= C; k++)
            {
                for (l = 0; l <= C; l++)
                {
                    if (k == l)
                    {
                        Console.WriteLine("The Given Character {0} appears {1} times", search[k], freq[l]);
                    }
                    if (k == l && k == m)
                    {
                        Console.WriteLine("The Character {0} appears Maximum {1} times", search[k], freq[l]);
                        break;
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
