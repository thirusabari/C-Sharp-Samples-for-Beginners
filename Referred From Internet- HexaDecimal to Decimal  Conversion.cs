using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion7
{
    class Program
    {
        static void Main(string[] args)
        {
            string HexaDecimal;
            int Decimal;
            Console.WriteLine("HexaDecimal to Decimal Conversion");
            Console.WriteLine("Enter the input HexaDecimal Value:");
            HexaDecimal = Console.ReadLine();
            Decimal = int.Parse(HexaDecimal, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("The Decimal Converted Output Value is:");
            Console.WriteLine(Decimal);
            Console.ReadLine();
        }
    }
}
