using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array23
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, row, column;
            Console.WriteLine("The Transpose of an Matrix:");
            Console.WriteLine("Enter the Rows of the Matix");
            row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the columns of the Matrix");
            column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, column];
            Console.WriteLine("Enter the values of A Matrix");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The A Matrix:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("The Transpose of Given matrix A is:");
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    Console.Write("{0} ",a[j,i]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
