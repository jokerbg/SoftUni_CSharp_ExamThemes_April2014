using System;
class ConsoleGraphics
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}\n{0}", new string('*', 2 * n));
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('*', (n + 1) / 2), new string(' ', n - 1));
        }
        Console.WriteLine("{0}\n{0}", new string('~', 2 * n));
    }
}