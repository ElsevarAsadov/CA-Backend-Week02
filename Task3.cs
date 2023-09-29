
using System;

class Program
{
    static void Main()
    {
        //3. Verilmis arrayde ededlerin ededi ortasini tapin.
        
        int[] arr = { 3, 3, -3 };
        float m = 0;
        int i;
        for (i = 1; i < arr.Length + 1; i++)
        {
            m += arr[i - 1];
        }
        m /= (i - 1);
        
        Console.WriteLine($"Ededi Orta: {m}");
        

     
    }
}

