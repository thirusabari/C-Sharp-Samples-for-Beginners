using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication173
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the string:");
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            int L,i,j;
            L = a.Length;
            string given = string.Empty;
            string word = string.Empty;
            for (i = 0; i < L; i++)
            {
                if((a[i]==' ')||((int)a[i]>=0&&(int)a[i]<=47)||((int)a[i]>=58&&(int)a[i]<=64)||((int)a[i]>=91&&(int)a[i]<=96)||((int)a[i]>=123&&(int)a[i]<=127))
                {
                    if (word == "is")
                    {
                        word = "is not";
                        given = given + word+a[i];
                        word = string.Empty;
                    }
                    else
                    {
                        given = given + word+a[i];
                        word = string.Empty;
                        
                    }
                    continue;
                }
               if(((int)a[i]>=65&&(int)a[i]<=90)||((int)a[i]>=97&&(int)a[i]<=122))
               {
                   word = word + a[i];
               }
               if (i == L - 1)
               {
                   if (word == "is")
                   {
                       word = "is not";
                       given = given + word;
                       break;
                   }
                   else
                   {
                       given = given + word;
                   }
               }
            }
            Console.WriteLine("\n");
            Console.WriteLine(given);
            Console.ReadLine();

        }
    }
}
