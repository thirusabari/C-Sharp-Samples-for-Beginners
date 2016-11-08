using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication96
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date to display the month:");
            string date = Console.ReadLine();
            string d = string.Empty;
            string m = string.Empty;
            string y = string.Empty;
            int i, j, L,count=0;
            L = date.Length;
            for (i = 0; i < L; i++)
            {
                if (date[i] == '-')
                {
                    count++;
                }
                else if (count == 1)
                {
                    m = m + date[i];
                }
                else if (count == 2)
                {
                    y = y + date[i];
                }
                else
                {
                    d = d + date[i];
                }
            }
            Console.WriteLine("The month,date,year given are:");
            Console.WriteLine(m);
            Console.WriteLine(d);
            Console.WriteLine(y);
            Console.WriteLine("The Month is");
            Console.WriteLine("\n");
            switch (m)
            {
                case "01":
                case "1":
                    Console.WriteLine("January");
                    break;
                case "02":
                case "2":
                    Console.WriteLine("February");
                    break;
                case "03":
                case "3":
                    Console.WriteLine("March");
                    break;
                case "4":
                case "04":
                    Console.WriteLine("April");
                    break;
                case "5":
                case "05":
                    Console.WriteLine("May");
                    break;
                case "6":
                case "06":
                    Console.WriteLine("June");
                    break;
                case "7":
                case "07":
                    Console.WriteLine("July");
                    break;
                case "8":
                case "08":
                    Console.WriteLine("August");
                    break;
                case "9":
                case "09":
                    Console.WriteLine("September");
                    break;
                case "10":
                    Console.WriteLine("October");
                    break;
                case "11":
                    Console.WriteLine("November");
                    break;
                case "12":
                    Console.WriteLine("December");
                    break;
            }
            Console.ReadLine();
        }
    }
}
