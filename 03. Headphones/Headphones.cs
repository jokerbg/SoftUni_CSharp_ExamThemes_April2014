using System;
class Headphones
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', n + 2));

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2), new string('-', n));
        }

        for (int i = 0; i < (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (n - 1) / 2 - i), new string('*', 2 * i + 1), new string('-', n - 2 * i));
        }

        for (int i = (n - 3) / 2; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', (n - 1) / 2 - i), new string('*', 2 * i + 1), new string('-', n - 2 * i));
        }
    }
}