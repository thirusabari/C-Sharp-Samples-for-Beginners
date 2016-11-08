using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Find the Youngest age of 3 peoples");
            Console.WriteLine("Enter the Number of People");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] peoples = new string[N];
            int i;
            Console.WriteLine("\n");
            Console.WriteLine("Enter the People Names");
            for (i = 0; i < peoples.Length; i++)
            {
                peoples[i] = Console.ReadLine();
            }
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < peoples.Length; i++)
            {
                if (a1 > a2 && a1 > a3&&i==0)
                {
                    Console.WriteLine("The Youngest age is {0}= {1}",peoples[i], a1);
                    break;
                }
                else if (a2 > a1 && a2 > a3 && i == 1)
                {
                    Console.WriteLine("The Youngest age is{0} ={1}", peoples[i], a2);
                    break;
                }
                else if (i == 2)
                {
                    Console.WriteLine("The youngest age is {0}={1}", peoples[i], a3);
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
