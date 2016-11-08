using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2space
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int count = 0;
            int j = 0;
            int[] pos = new int[100];
            string[] output = new string[100];
            string dis="";
            output[0] = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count = count + 1;
                    j++;
                    continue;
                }
                output[j] = output[j] + str[i];
            }
            for(int i=0;i<=count;i++)
            {
                dis = dis + output[i];
            }
            Console.WriteLine("After removing the Space:");
            Console.WriteLine(dis);

            Console.ReadKey();
        }
    }
}
