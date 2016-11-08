using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication148
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string a = Console.ReadLine();
            char[] b = a.ToCharArray();
            int L1 = b.Length;
            int i, j,count=0;
            string c = string.Empty;
            string num = string.Empty;
            string letter = string.Empty;
            for (i = 0; i < L1; i++)
            {
                if (((int)b[i] >= 65 && b[i] <= 90) || ((int)b[i] >= 97 && b[i] <= 122))
                {
                    c = c + b[i];
                }
                else if ((int)b[i] >= 48 && (int)b[i] <= 57)
                {
                    num = num + b[i];
                }
            }
            int L = c.Length;
            int n = Convert.ToInt32(num);
            if(L>(2*n))
            {
                char[] d = c.ToCharArray();
                int L2 = d.Length;
                for (i = 0; i < n; i++)
                {
                    letter = letter + d[i];
                }
                for (j = L2 - n; j<L2; j++)
                {
                    letter = letter + d[j];    
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(letter);
            Console.ReadLine();
        }
    }
}
