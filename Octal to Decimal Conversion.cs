using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i;
            Console.WriteLine("Octal to Decimal Conversion");

            double D, N;
            double Decimal = 0;
            Console.WriteLine("Enter the Maximum Length of the Digits");
            N = Convert.ToDouble(Console.ReadLine());
            double[] Octal = new double[10];
            Console.WriteLine("Enter the Octal Input Value:");
            for (i = 0; i < N; i++)
            {
                Octal[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The Converted Decimal Value is=");
            for (i = 0; i < Octal.Length; i++)
            {
                N = N - 1;
                D = Math.Pow(8, N);
                Decimal = Decimal + D * Octal[i];
            }
            Console.WriteLine(Decimal);
            Console.ReadLine();
            
        }
    }
}
