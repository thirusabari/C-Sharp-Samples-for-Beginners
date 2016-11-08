using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();
            s.Add("thirunavukkarasu");
            s.Add("Sabarinathan");
            s.Add("Prabhu");
            s.Add("Gopalakrishnan");
            s.Add("Vino");
            s.Add("Baby");
            s.Add("Lalitha");
            s.Sort();
            Console.WriteLine("Sorting of string using List with Sort Method");
            foreach (string S in s)
            {
                Console.WriteLine(S);
            }
            Console.ReadLine();
        }
    }
}
