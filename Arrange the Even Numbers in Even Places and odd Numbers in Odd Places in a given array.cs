using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication76
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, N,temp=0,Even=0,Odd=1;
            Console.WriteLine("Enter the Maximum Range of Numbers to Be Entered:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] b = new int[N];
            
            for (i = 0; i < N; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The input Values entered are:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < N; i++)
            {
                Even = 0;
                Odd = 1;
                while(Even<N&&a[Even]%2==0)
                {
                    Even+=2;
                }
                while (Odd < N && a[Odd] % 2 == 1)
                {
                    Odd += 2;
                }
                if (Even < N && Odd < N)
                {
                    temp = a[Even];
                    a[Even] = a[Odd];
                    a[Odd] = temp;
                }
                else
                {
                    break;
                }
            }
            
            for (i = 0; i < N; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
