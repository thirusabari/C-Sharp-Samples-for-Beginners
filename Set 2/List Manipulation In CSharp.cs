using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manipulation of List");
            List<int> Hai = new List<int>();
            Hai.Add(1);
            Hai.Add(23);
            Hai.Add(45);
            Hai.Add(67);
            Hai.Add(100);
            Hai.Insert(3, 48);
            Hai.Insert(5, 1000);
            foreach (int h in Hai)
            {
                Console.Write("{0} ", h);
            }
            Console.WriteLine("\n");
            List<string> Hello = new List<string>();
            Hello.Add("Thiru");
            Hello.Add("Arasu");
            Hello.Add("Selva");
            Hello.Add("Surya");
            Hello.Insert(3, "Vela");
            Hello.Insert(2, "Sharmela");
            Hello.Insert(1, "MuthuKumar");
            Hello.Add("Thirumurugan");
            Hello.Sort();
            Hello.Remove("Sharmela");
            if (Hello.Contains("Vela"))
            {
                Console.WriteLine("Vela Existing in the List");
            }
            for (int k = 0; k < Hello.Count; k++)
            {
                Console.Write("{0} ", Hello[k]);
            }
            Console.WriteLine("\n");
            string[] a = new string[3];
            a[0] = "pavi";
            a[1] = "suba";
            a[2] = "mega";
            Console.WriteLine("\n");
            List<string> A = new List<string>(a);
            foreach (string aa in A)
            {
                Console.WriteLine(aa);
            }
            string combinedstring = string.Join(",", Hello);
            Console.WriteLine(combinedstring);
            string[] How = Hello.ToArray();
            Hai.Clear();
            Console.ReadLine();
        }
    }
}
