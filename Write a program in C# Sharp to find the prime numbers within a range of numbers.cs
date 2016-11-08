using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, I, n;
            Console.WriteLine("Prime Number");
            Console.WriteLine("Enter the N Value:");
            n = Convert.ToInt32(Console.ReadLine());
            for (I = 2; I <= n; I++)
            {
                for (i = 2; i <= n; i++)
                {

                    if (I % i == 0)
                    {
                        break;

                    }
                }
                if (I == i)
                {
                    Console.WriteLine("The given number is an prime number={0}", I);
                }    
            }
            
                
                
                
                
                
        Console.ReadLine();    
        }
            
        }
    }


