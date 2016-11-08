using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion10
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, remainder = 0, n; int DECIMAL;
            Console.WriteLine("Octal to HexaDecimal Conversion");

            double D, N;
            double Decimal = 0; string HexaDecimal = string.Empty;
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
            Console.WriteLine("\n");
            DECIMAL = Convert.ToInt32(Decimal);
            Console.WriteLine("Decimal to HexaDecimal Conversion");
            for (n = DECIMAL; n != 0; n = n / 16)
            {
                remainder = n % 16;
                switch (remainder)
                {
                    case 10:
                        string R = "A";
                        HexaDecimal = HexaDecimal + R;
                        break;
                    case 11:
                        string rem = "B";
                        HexaDecimal = HexaDecimal + rem;
                        break;
                    case 12:
                        string val = "C";
                        HexaDecimal = HexaDecimal + val;
                        break;
                    case 13:
                        string Rem = "D";
                        HexaDecimal = HexaDecimal + Rem;
                        break;
                    case 14:
                        string value = "E";
                        HexaDecimal = HexaDecimal + value;
                        break;
                    case 15:
                        string Remainder = "F";
                        HexaDecimal = HexaDecimal + Remainder;
                        break;
                    default:
                        HexaDecimal = HexaDecimal + remainder.ToString();
                        break;
                }


            }
            Console.WriteLine("The HexaDecimal Converted Value is:");
            for (i = HexaDecimal.Length - 1; i >= 0; i--)
            {
                Console.Write(HexaDecimal[i]);
            }
            Console.ReadLine();
        }
    }
}
