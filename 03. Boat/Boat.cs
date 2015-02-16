using System;
class Boat
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i <= (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', n - 1 - 2 * i), new string('*', 1 + 2 * i), new string('.', n));
        }

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', 2 * i), new string('*', n - 2 * i), new string('.', n));
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', n * 2 - 2 * i));
        }
    }
}