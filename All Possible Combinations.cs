using System;
using System.Collections;

class formPermut
{
     int j,t=1 ;
    int[] arr = new int[720];
    int[] arr2 = new int[100];
    int co=0,co2;
    
    public void swap(ref  int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void seq(int[] list, int k, int m)
    {
        if (co == 0)
        {
            for (int o = m + 1; o >= 1; o--)
            {
                t = t * o;
            }
        }
        int co1 = 0;
        co++;
       
        int[] arr1 = new int[t];
        int i;
        if (k == m)
        {
            for (i = 0; i <= m; i++)
            {
               // Console.Write("{0}", list[i]);
                arr[j] =Convert.ToInt32(( arr[j].ToString() )+ list[i]);
              
            }
          
            j++;
           
            Console.Write(" ");
            
        }
        else
            for (i = k; i <= m; i++)
            {

                swap( ref list[k], ref list[i]);
               seq(list, k + 1, m);
                swap(ref list[k], ref list[i]);
             }

        ArrayList al = new ArrayList(arr);
        al.Sort();
        // int[] arr1 = new int[t];


        if (j == (t))
        {
            if (co2 == 0)
            {
                Console.WriteLine("Max Number from the given array is:"+(int)al[719]);
                co2++;
            }
        }
        
    }
    
   // Console.WriteLine(al[5]);
}
class RecExercise11
{
    public static void Main()
    {
        int n, i;
        formPermut test = new formPermut();
        int[] arr1 = new int[6];

     
        Console.Write("Input the number of elements to store in the array [maximum 6 digits ] :");
        n = Convert.ToInt32(Console.ReadLine());
  
        for (i = 0; i < n; i++)
        {
            Console.Write(" element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        int j ;
      
        test.seq(arr1, 0, n - 1);
      
        Console.ReadLine();
    }
}
