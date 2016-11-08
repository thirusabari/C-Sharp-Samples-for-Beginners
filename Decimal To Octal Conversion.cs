using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Decimal,Remainder,n,i;            
            string Octal = string.Empty;
            Console.WriteLine("Decimal to Octal Conversion");
            Console.WriteLine("Enter the Decimal Value");
            Decimal = Convert.ToInt32(Console.ReadLine());
            n = Decimal;
            for(n=Decimal;n!=0;n=n/8)
            {
                Remainder = n % 8;
                Octal = Octal + Remainder.ToString();
            }
            Console.WriteLine("The Octal Value is:");
            for (i = Octal.Length - 1; i >= 0; i--)
            {
                Console.Write(Octal[i]);
            }


            Console.ReadLine();

        }
    }
}
