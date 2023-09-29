
using System;

class Program
{
    static void Main()
    {
        //1. Arrayde tek indeksde duran ededlerin hasilini tapin.

        int[] arr = { 1, 10, 1, 10 };
        if (arr.Length > 0)
        {
            int product = 1;
            for (int i = 1; i < arr.Length; i += 2)
            {
                product *= arr[i];
            }

            Console.WriteLine($"Cem: {product}");

        }
        else Console.WriteLine($"Product: 0");


    }
}

