using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,count=0,remainder=0,Happy=0,A,temp;
            Console.WriteLine("Programs to Find Happy Number:");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the Number:");
            a = Convert.ToInt32(Console.ReadLine());
            A = a;
            while(a != 0)
            {
                remainder = A % 10;
                Happy = Happy + remainder * remainder;
                A = A / 10;
                count++;
                if (Happy == 1)
                {
                    Console.WriteLine("The given number {0} is an Happy Number={1}", a, Happy);
                    break;
                }
                else if (Happy == (a * a))
                {
                    Console.WriteLine("The Given number {0} is an Sad Number={1}", a, Happy);
                    break;

                }
                else if (A == 0)
                {
                    temp = A;
                    A = Happy;
                    Happy = temp;
                }
                
            }
            Console.ReadLine();

        }
    }
}
