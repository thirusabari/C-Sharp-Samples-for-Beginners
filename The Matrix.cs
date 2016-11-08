using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THe Matrix");
            Console.WriteLine("\n");
            int row = 3, column = 3, i, j, n = row * column; string num = string.Empty;
            int[,] a = new int[row,column];
            Console.WriteLine("Enter the elements of the matrix");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            int[] c = new int[n];
            int d = 0;
            Console.WriteLine("The input Elements in 2-D Array is");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                    c[d] = a[i, j];
                    d++;
                }
                Console.WriteLine("\n");
            }
            int N=row*column;
            int[] b = new int[9] { 0, 1, 3, 6, 4, 2, 5, 7, 8 };
            int k;
            Console.WriteLine("The Required Pattern is");
            Console.WriteLine("\n");
            for (k = 0; k < N; k++)
            {
                num = string.Empty;
                for (d = b[k]; d < n; )
                {
                    num = num + c[d].ToString();
                    if (num.Length == 1)
                    {
                        Console.Write(num);
                        break;
                    }
                    else if (num.Length > 1)
                    {
                        Console.Write("{0} ", num);
                        break;
                    }
                    
                     
                }
                
            }
            Console.WriteLine("\n");
            Console.ReadLine();
            

        }
    }
}
