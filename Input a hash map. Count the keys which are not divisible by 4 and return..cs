using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ConsoleApplication129
{
    class Program
    {
        static NameValueCollection GetKeys()
        {
            NameValueCollection KEYS = new NameValueCollection();
            KEYS.Add("12", "hai");
            KEYS.Add("13", "Hello");
            KEYS.Add("25", "VAAL");
            KEYS.Add("37", "surya");
            KEYS.Add("85", "hope");
            KEYS.Add("52", "Lie");
            KEYS.Add("101", "dance");
            KEYS.Add("359", "SONG");
            KEYS.Add("121", "Value");
            KEYS.Add("200", "ego");
            KEYS.Add("501", "tension");
            KEYS.Add("1012", "need");
            return KEYS;
        }
        static void Main(string[] args)
        {
            NameValueCollection KEYS = GetKeys();
            int i=0, c = 0, count=0;
            int[] k=new int[15];
            foreach (string key in KEYS)
            {
                k[i] = Convert.ToInt32(key);
                i++;
                c++;
            }
            for (i = 0; i <= c; i++)
            {
                if (k[i] % 4 == 0)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("The count of Keys which are not divisible by 4 is={0}", count);
            Console.ReadLine();
        }
    }
}
