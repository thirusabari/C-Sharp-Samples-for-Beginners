using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication198
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lucky sum");
            int N, count = 0, i, j,p=0,sum=0;
            Console.WriteLine("Enter the Maximum Range for the array");
            N=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int[] pos=new int[N];
            Console.WriteLine("ENter the input values:");
            for(i=0;i<N;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values are:");
            for(i=0;i<N;i++)
            {
                Console.Write("{0} ",a[i]);
            }
            Console.WriteLine("\n");
            for(i=0;i<N;i++)
            {
                if(a[i]==13)
                {
                    count++;
                }
                else if(count==0)
                {
                    pos[p]=i;
                    p++;
                }
            }
            j=0;j=p;
            count=0;
            if(p!=0)
            {
                for(i=count;i<N;i++)
                {
                    for(p=count;p<j;p++)
                    {
                        if(i==pos[p])
                        {
                            count++;
                            sum=sum+a[i];
                            break;
                           
                        }
                        else
                        {
                            count++;
                            break;
                        }
                    }
                }
            }
            else if(p==0)
            {
                for(i=0;i<N;i++)
                {
                    sum=sum+a[i];
                }
            }
            Console.WriteLine("\n");
           Console.WriteLine(sum);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
