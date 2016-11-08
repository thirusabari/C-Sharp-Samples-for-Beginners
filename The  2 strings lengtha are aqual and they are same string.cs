using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b; int i,value=0,l1,l2,relative=0;
            Console.WriteLine("String Comaparison without using builtin Functions");
            Console.WriteLine("Enter the First String:");
            a = Console.ReadLine();
            Console.WriteLine("ENter the Second String:");
            b = Console.ReadLine();
            l1 = a.Length;
            l2 = b.Length;
            /* Compare and Checking whether the strings are equal in string or not*/
            if (l1 == l2)
            {
                for(i=0;i<l1;i++)
                {
                    value=1;
                    i = l1;
                }
            }
            /*Initialize relative when they are equal,smaller and larger in Length*/
            if (l1 == l2)
                relative = 0;
            else if (l1 > l2)
                relative = 1;
            else if (l1 < l2)
                relative = -1;
            /*Display the message,whether the two strings are equal in length and input string value*/
            if (relative == 0)
            {
                if (value == 0)
                {
                    Console.WriteLine("The  2 strings lengths are aqual and they are same string");

                }
                else
                    Console.WriteLine("The  2 strings lengths are aqual and they are not same string");
            }
            else if (relative == -1)
            {
                Console.WriteLine("The length of the first string is smaller than second");
            }
            else if (relative == 1)
            {
                Console.WriteLine("The length of the Second String is Smaller than First");
            }
            
            Console.ReadLine();
        }
    }
}
