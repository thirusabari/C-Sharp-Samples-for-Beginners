using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ConsoleApplication124
{
    class Program
    {
        static NameValueCollection KeyVal()
        {
            NameValueCollection Max = new NameValueCollection();
            Max.Add("12", "hello");
            Max.Add("20", "Happy");
            Max.Add("100", "Best Performer");
            Max.Add("80", "Better");
            Max.Add("56", "GoodLuck");
            return Max;
        }
        static void Main(string[] args)
        {
            int i, j,count = 0, N,m=0,max=0;
            string num = string.Empty;
            string word = string.Empty;
            NameValueCollection Max = KeyVal();
            Console.WriteLine("Enter the Maximum Values of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[N];
            Console.WriteLine("Enter the Values");
            for (i = 0; i < N; i++)
            {
                a[i] = Console.ReadLine();
            }
            int[] M = new int[N];
            foreach (string key in Max)
            {
                M[m] = Convert.ToInt32(key);
                m++;
                
            }
            for (m = 0; m <N; m++)
            {
                if (M[m] > max)
                {
                    max = M[m];
                }

            }
            for (i = 0; i < N; i++)
            {
                char[] B = a[i].ToCharArray();
                count = 0;
                word = string.Empty;
                num = string.Empty;
                for (j = 0; j < B.Length; j++)
                {
                    if (B[j] == ':' || B[j] == '-')
                    {
                        count++;
                        continue;
                    }
                    else if (count == 1)
                    {
                        word = word + B[j];
                    }
                    else if (count == 0)
                    {
                        num = num + B[j];
                    }
                }
                if (max == Convert.ToInt32(num))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(word);
                    break;
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
