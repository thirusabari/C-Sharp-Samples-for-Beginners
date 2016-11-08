using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Driven Program for Switch case");
            while (true)
            {
                Console.WriteLine("1.Factorial");
                Console.WriteLine("2.Prime or not");
                Console.WriteLine("3.Odd or Even");
                Console.WriteLine("Press key 4 to exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Program to Find the Given Number is Factorial of given number");
                        int fact = 1, i, n;
                        Console.WriteLine("Enter the Maximum Range of Factorial Series");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine("The Factorial of given number {0} is={1}", n, fact);
                        break;
                    case 2:
                        Console.WriteLine("Program to display prime numbers between particular interval");
                        Console.WriteLine("Enter the Maximum Range of prime numbers");
                        int N = Convert.ToInt32(Console.ReadLine());
                        int I, J;
                        for (I = 1; I <= N; I++)
                        {
                            for (J = 2; J <= I; J++)
                            {
                                if (I % J == 0)
                                {
                                    break;
                                }
                            }
                            if (I == J)
                            {
                                Console.Write("{0} ", J);
                            }
                            
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Program to Find the Given number is odd or even");
                        Console.WriteLine("Enter the Number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int x;
                        x = num % 2;
                        if (x == 0)
                        {
                            Console.WriteLine("The Given Number is an Even Number={0}", num);
                        }
                        else
                        {
                            Console.WriteLine("The Given Number is an Odd Number={0}", num);
                        }
                        break;
                    case 4:
                        Console.ReadLine();
                        break;
                                        
                }
            }
            Console.ReadLine();
        }
    }
}
