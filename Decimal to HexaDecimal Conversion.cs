using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Decimal,n,remainder,i;
            string HexaDecimal = string.Empty;
            Console.WriteLine("Decimal to HexaDecimal Conversion");
            Decimal = Convert.ToInt32(Console.ReadLine());
            for (n = Decimal; n != 0; n = n / 16)
            {
                remainder = n % 16;
                switch (remainder)
                {
                    case 10:
                        string  R = "A";
                        HexaDecimal = HexaDecimal +R;
                        break;
                    case 11:
                        string rem = "B";
                        HexaDecimal = HexaDecimal +rem;
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
