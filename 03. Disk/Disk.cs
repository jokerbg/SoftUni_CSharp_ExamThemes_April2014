using System;
class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int centerX = n / 2 + 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write((radius * radius < (centerX - i) * (centerX - i) + (centerX - j) * (centerX - j)) ? "." : "*");
            }
            Console.WriteLine();
        }
    }
}