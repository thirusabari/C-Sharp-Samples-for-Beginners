using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Manipulation");
            int i, p = 0, e = 0, n = 0, o = 0, N,I=0,J=0,K=0,L=0,c1=0,c2=0,c3=0,c4=0;
            Console.WriteLine("Enter the Maximum Range of the Array:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] pos = new int[N];
            int[] neg = new int[N];
            int[] odd = new int[N];
            int[] even = new int[N];
            Console.WriteLine("Enter the Values of the Input Array");
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Input Values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                if (a[i] > 0)
                {
                    p++;
                    pos[I] = a[i];
                    I++;                    
                }
                if (a[i] < 0)
                {
                    n++;
                    neg[J] = a[i];
                    J++;
                }
                if (a[i] % 2 == 0)
                {
                    e++;
                    even[K] = a[i];
                    K++;
                }
                if(a[i]%2==1)
                {
                    o++;
                    odd[L] = a[i];
                    L++;
                }
            }
            Console.WriteLine("The positive Values are:");
            for (I = 0; I <= p; I++)
            {
                c1++;
                Console.Write("{0} ", pos[I]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The count value={0}", c1);
            Console.WriteLine("\n");
            Console.WriteLine("The Negative Values are");
            for (J = 0; J <= n; J++)
            {
                c2++;
                Console.Write("{0} ", neg[J]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The count value={0}", c2);
            Console.WriteLine("\n");
            Console.WriteLine("The Even Values are");
            for (K = 0; K <= e; K++)
            {
                c3++;
                Console.Write("{0} ", even[K]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The count value={0}", c3);
            Console.WriteLine("\n");
            Console.WriteLine("The Odd Values are");
            for (L = 0; L <= o; L++)
            {
                c4++;
                Console.Write("{0} ", odd[L]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("The count value={0}", c4);
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
