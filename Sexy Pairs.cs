using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication209
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sexy Pairs");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Maximum Range");
            int N = Convert.ToInt32(Console.ReadLine());
            int i, j,k=0,sexy=6,sum=0;
            int[] primes = new int[N];
            int p = 0;
            for (i = 2; i <= N; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        
                        break;
                    }
                    
                }
                if (i==j)
                {
                    primes[p] = i;
                    p++;
                }
            }
            j = 0; j = p; k = 0;
            Console.WriteLine("\n");
            Console.WriteLine("The PrimeNumbers between 1 to {0} is", N);
            for (p = 0; p < j; p++)
            {
                Console.Write("{0} ", primes[p]);
            }
            Console.WriteLine("\n");
            i = 0; int n = 0,s=0;
          
                while(n<p)
                {
                    sum = 0;
                    sum = primes[n]+ sexy;

                    for (k = 2; k <sum; k++)
                    {
                        if (sum % k == 0)
                        {

                            break;
                        }
                        
                        
                    }
                    if (sum==k)
                    {
                        Console.Write("({0},{1}) ", primes[n], sum);
                        
                    }
                    n++;
                }
             
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
