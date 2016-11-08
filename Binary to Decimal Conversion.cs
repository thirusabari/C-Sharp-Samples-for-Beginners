using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,i; 
            Console.WriteLine("Binary to Decimal Conversion");
             
            double D,N;
            double Decimal=0;
            Console.WriteLine("Enter the Maximum Length of the Digits");
            N=Convert.ToDouble(Console.ReadLine());
            double[] Binary=new double[10];
            Console.WriteLine("Enter the Binary Input Value:");
            for (i = 0; i < N; i++)
            {
                Binary[i] =Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The Converted Decimal Value is=");
            for (i = 0; i <Binary.Length; i++)
            {
                N = N - 1;
                D = Math.Pow(2, N);
                Decimal = Decimal + D*Binary[i];
            }
            Console.WriteLine(Decimal);
             Console.ReadLine();
            
        }
    }
}
