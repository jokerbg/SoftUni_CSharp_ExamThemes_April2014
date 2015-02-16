using System;
class Nums
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int m = Int32.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("{0:F3}", i * i);
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(i));
            }
        }
    }
}