using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ad, sub, mul;double div, modul;
            ad = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
            modul = a % b;
            Console.WriteLine("The Add={0}", ad);
            Console.WriteLine("The Sub={0}", sub);
            Console.WriteLine("The Mul={0}", mul);
            Console.WriteLine("The div={0}", div);
            Console.WriteLine("The Modulo={0}", modul);
            Console.ReadLine();

        }
    }
}
