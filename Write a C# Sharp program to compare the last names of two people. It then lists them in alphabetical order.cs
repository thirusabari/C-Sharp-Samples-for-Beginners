using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace String22
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "John Peterson";
            string name2 = "Michel Johnson";

            //Get Position of Space Character
            int index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : index1--;

            int index2 = name2.IndexOf(" ");
            index2 = index2 < 0 ? 0 : index2--;

            int Length = Math.Max(name1.Length, name2.Length);
            Console.WriteLine("The last names Sorted Alphabetically");
            if(string.Compare(name1,index1,name2,index2,Length,new CultureInfo("en-US"),CompareOptions.IgnoreCase)<0)
                Console.WriteLine("{0}\n{1}",name1,name2);
            else
                Console.WriteLine("{0}\n{1}",name2,name1);
            Console.ReadLine();
        }
    }
}
