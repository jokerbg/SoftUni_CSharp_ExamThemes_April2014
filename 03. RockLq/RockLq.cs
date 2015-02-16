using System;
class RockLq
{
    static void Main()
    {
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', input), new string('*', input));

        for (int i = input - 2; i > 0; i -= 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (3 * input - 2 * i - 2)));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', input - 2), new string('.', input));

        for (int i = 1; i <= input - 4; i += 2)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', input - 3 - i), new string('.', i), new string('.', input));
        }

        for (int i = input - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', 3 * input - 2 * i - 2));
        }
        Console.WriteLine(new string('*', 3 * input));
    }
}