using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic11
{
    class Program
    {
        static void Main(string[] args)
        {
            float cenmet = Convert.ToInt32(Console.ReadLine());
            if (cenmet >= 150.0)
            {
                Console.WriteLine("The Person is tall");
            }
            else if (cenmet < 100.0)
            {
                Console.WriteLine("The Person is Lower Height");
            }
            else if (cenmet > 100 && cenmet < 150)
            {
                Console.WriteLine("The Person name is Medium Height");
            }
            
                Console.ReadLine();

        }
    }
}
