using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string a = Console.ReadLine();
            int i=a.Length;
            string b = " ";
            
            for ( int j=i-1; j >= 0; j--)
            {
                b = b + a[j].ToString();
                
            }
            Console.WriteLine("The Reversed String is={0}",b);
            Console.ReadLine();
        }
    }
}
