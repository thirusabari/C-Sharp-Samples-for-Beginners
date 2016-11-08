using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Number_of_Vowels_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            int count = 0;
           for(int i=0;i<a.Length;i++)
           {
               if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
               {
                   count++;

               }
           }
         Console.WriteLine("\n");
         Console.WriteLine("The string={0} contains vowels={1}",a, count);
            Console.ReadLine();
        }
    }
}
