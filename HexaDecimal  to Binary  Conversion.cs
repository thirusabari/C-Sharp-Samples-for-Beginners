using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexadecimal_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HexaDecimal to Binary Conversion");
            string HexaDecimal = Console.ReadLine();
            int L = HexaDecimal.Length;
            char[] a = HexaDecimal.ToCharArray(0,L);
            int i, j=0;
            string Binary = string.Empty;
            for (i = 0; i < L; i++)
            {
                switch (a[i])
                {
                    case '0':
                        j = 0000;
                        break;
                    case '1':
                        j = 0001;
                        break;
                    case '2':
                        j = 0010;
                        break;
                    case '3':
                        j = 0011;
                        break;
                    case '4':
                        j = 0100;
                        break;
                    case '5':
                        j = 0101;
                        break;
                    case '6':
                        j = 0110;
                        break;
                    case '7':
                        j = 0111;
                        break;
                    case '8':
                        j = 1000;
                        break;
                    case '9':
                        j = 1001;
                        break;
                    case 'A':
                        j=1010;
                        break;
                    case 'B':
                        j=1011;
                        break;
                    case 'C':
                        j = 1100;
                        break;
                    case 'D':
                        j = 1101;
                        break;
                    case 'E':
                        j = 1110;
                        break;
                    case 'F':
                        j = 1111;
                        break;
                    default:
                        j = 0;
                        break;

                }
                Binary = Binary + j.ToString();
            }
            Console.WriteLine("The Binary Converted Value is={0}", Binary);
            Console.ReadLine();
        }
    }
}
