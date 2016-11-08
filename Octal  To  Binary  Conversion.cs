using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int octal,j,L, remainder = 0; string Binary = string.Empty; int R;
            Console.WriteLine("Octal to Binary Conversion"); string b=string.Empty; string c = string.Empty;
            Console.WriteLine("ENter the Octal Value");
            octal = Convert.ToInt32(Console.ReadLine());
            string B = string.Empty;
            while(octal != 0)
            {
                remainder = octal % 10;
                Binary = Binary + remainder.ToString();
                octal = octal / 10;
            }
            Console.WriteLine(Binary);
            L = Binary.Length;
             for(R=L-1;R>=0;R--)
             {
                  B=B+Binary[R];     
             }
             Console.WriteLine("The Octal Equivalent Value is");
            for(j=0;j<B.Length;j++)
            {
            switch (B[j])
                 {
                     case '0':
                         b= "000";
                         break;
                     case '1':
                         b = "001";
                         break;
                     case '2':
                         b = "010";
                         break;
                     case '3':
                         b = "011";
                         break;
                     case '4':
                         b = "100";
                         break;
                     case '5':
                         b = "101";
                         break;
                     case '6':
                         b= "110";
                         break;
                     case '7':
                         b = "111";
                         break;
                 }
                 c = c + b;
               }        
               Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
