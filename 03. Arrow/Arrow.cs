using System;
class Arrow
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', (number - 1) / 2), new string('#', number));
        for (int i = 1; i < number - 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', (number - 1) / 2), new string('.', number - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('#', (number + 1) / 2), new string('.', number - 2));

        for (int i = 1; i < number - 1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', 2 * number - 3 - 2 * i));
        }

        Console.WriteLine("{0}#{0}", new string('.', (number - 1)));
    }
}