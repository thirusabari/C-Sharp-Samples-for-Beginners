using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,N;
            Console.WriteLine("Matrix Addition");
            Console.WriteLine("Enter the MAximum Range of the Matrix:");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N,N];
            int[,] b=new int[N,N];
            int[,] sum=new int[N,N];
            Console.WriteLine("Enter the input Elements for Matrix A:");
            for(i=0;i<N;i++)
            {
                for(j=0;j<N;j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the input Elements for Matrix B:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("The Matrix A:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ",a[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("The Matirx B:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", b[i, j]);
                }
                Console.WriteLine("\n");
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
                
            }
            Console.WriteLine("The Sum Matrix is:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("{0} ", sum[i, j]);
                }
                Console.WriteLine("\n");
            }


            Console.ReadLine();

        }
    }
}
