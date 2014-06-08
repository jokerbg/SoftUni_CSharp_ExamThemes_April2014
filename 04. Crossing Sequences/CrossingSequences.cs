using System;
using System.Linq;
using System.Collections.Generic;
class CrossingSequences
{
    static void Main()
    {
        //Tribonacci sequence
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int arr = 0;

        List<int> tribonacci = new List<int>();
        tribonacci.Add(a);
        tribonacci.Add(b);
        tribonacci.Add(c);

        while (arr <= 1000000)
        {
            arr = a + b + c;
            tribonacci.Add(arr);
            a = b;
            b = c;
            c = arr;
        }

        //spiral sequence
        int initial = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counter = 1;

        List<int> spiral = new List<int>();
        spiral.Add(initial);

        while (initial <= 1000000)
        {
            spiral.Add(initial += step * counter);
            spiral.Add(initial += step * counter);
            counter++;
        }

        //check matches
        foreach (var item in spiral.Intersect(tribonacci))
        {
            if (item <= 1000000)
            {
                Console.WriteLine(item); return;
            }
        }
        Console.WriteLine("No");
    }
}