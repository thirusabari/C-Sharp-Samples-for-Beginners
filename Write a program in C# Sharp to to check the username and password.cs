using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String17
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int count = 0;
            Console.WriteLine("Program to Check whether username and password are correct or not");
            for (count = 0; count < 3; count++)
            {
                Console.WriteLine("Enter the username");
                username = Console.ReadLine();
                
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();
                if ((username == "uesr" && password == "pass") || (username == "abcd" && password == "1234"))
                {
                    Console.WriteLine("The entered username and password are correct");
                    Console.WriteLine("The Login successfully completed");
                    
                }
                else if (count == 2)
                {
                    

                    Console.WriteLine("The Login Failed..Three attempts finished");
                }
                Console.ReadLine();
            }
        }
    }
}
