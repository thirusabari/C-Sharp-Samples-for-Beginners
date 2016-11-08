using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array9a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,N,count;
            
            Console.WriteLine("Enter the Maximum Range for the Array");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            int[] freq = new int[N];
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();
                freq[i] = -1;
            }
            for (i = 0; i < N; i++)
            {
                count = 1;
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                    
                
                }
                if (freq[i] != 0)
                {
                    freq[i] = count;
                }
               
            }
            for (i = 0; i < N; i++)
            {
                if (freq[i] != 1)
                {
                    Console.Write("{0}{1}", a[i], freq[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
