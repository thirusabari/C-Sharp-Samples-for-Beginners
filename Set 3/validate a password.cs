using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication125
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            int i, L,digit=0,special=0,lower=0,upper=0,start=0,end=0;
            char[] p = password.ToCharArray();
            L = p.Length;
            for (i = 0; i < L; i++)
            {
                if (p[i] >= 48 && p[i] <= 58)
                {
                    digit++;

                }
                if (p[i] == '#' || p[i] == '$' || p[i] == '@')
                {
                    special++;
                }
                if ((int)p[i] >= 65 && (int)p[i] <= 90)
                {
                    upper++;
                }
                if ((int)p[i] >= 97 && (int)p[i] <= 122)
                {
                    lower++;
                }
                if(i==0)
                {
                    if ((int)p[i] >= 65 && (int)p[i] <= 90)
                    {
                        start++;
                    }
                }
                if (i==L-1)
               {
                   if ((int)p[i] >= 97 && (int)p[i] <= 122)
                   {
                       end++;
                   }
                }

            }
            if (digit == 1 && special == 1 && (L >= 6 && L <= 20) && (upper > lower) && start == 1 && end == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadLine();
        }
    }
}
