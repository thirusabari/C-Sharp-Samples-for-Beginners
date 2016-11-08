using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversion1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Binary=string.Empty;
         
           int Decimal,rem,n,i,L;
            Console.WriteLine("Decimal to Binary Number Conversion");
            Console.WriteLine("Enter the Decimal Number");
            Decimal = Convert.ToInt32(Console.ReadLine());
          
            for(n=Decimal;n!=0;n=n/2)
            {
                rem = n % 2;
                Binary = Binary + rem.ToString();
           }
            Console.WriteLine("The Binary Output Value is:");
           for (i = Binary.Length - 1; i >= 0; i--)
            {
                Console.Write(Binary[i]);
            }
            Console.ReadLine();
        }
    }
}
