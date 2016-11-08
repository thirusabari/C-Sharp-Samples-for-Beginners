using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcetanation
{
     class Program
    {
        public string concatenate(string a, string b)
        {
            char[] c = a.ToCharArray();

            char[] d = b.ToCharArray();

            char[] e = new char[c.Length + d.Length];
            int i = 0, j = 0, k = 0;
            while (i < c.Length)
            {
                e[k] = c[i];
                i++;
                k++;
            }
            while (j < d.Length)
            {
                e[k] = d[j];
                j++;
                k++;
            }
            string s = new string(e);
            return s;

        } 
public static void Main(string[] args)
        {

            Program obj = new Program();
            string a, b;
            Console.WriteLine("Enter two strings");
            a = Console.ReadLine();
            b = Console.ReadLine();

            string str = obj.concatenate(a, b);
            Console.WriteLine("Concatenate string is:{0}", str);


            Console.ReadKey();

        }
    }

} 


