using System;
class HouseWindow
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', n - 1));
        for (int i = n - 2; i >= 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (n * 2 - 3 - 2 * i)));
        }
        Console.WriteLine(new string('*', 2 * n - 1));
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('.', n / 2), new string('*', 2 * n - 3 - n));
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
        }
        Console.WriteLine(new string('*', 2 * n - 1));
    }
}