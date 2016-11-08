using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PerfectNumbers
{
    class Program
    {
       static void Main(string[] args)
        {
            int n=Convert.ToInt16(Console.ReadLine());
            int output;
            int[] values={n};
            int[] divisions = { 2, 3, 4, 6, 8 };
            int sum = 0;
            foreach(int j in divisions)
            {
                      
                    output = n / j;
                    //Console.WriteLine("the values are={0}", output);
                    int[] value = { output };
                
                foreach (int k in value)
                {
                    
                    sum = sum + k;
                    
                   
                    if (sum == n)
                    {
                        Console.WriteLine("The Perfect number of {0} is {1} ", n, sum);
                    }
                }
             foreach(int N in values)
                {
                 output=N/j;
                 Console.WriteLine("The output value is:{0}",output);

                }
             //for (int s = n; s <= values.Length; s++)
             //{
             //    Console.WriteLine("The values are  changed as:{0}", s);
             //}
                values.ToArray();
                switch()
                {
                    case 'A':


            
            }
                    Console.ReadKey();
         }
    }
}
