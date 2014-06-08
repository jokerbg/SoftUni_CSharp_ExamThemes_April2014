using System;
class Sunglasses
{
    static void Main()
    {
        int input = Int32.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * input), new string(' ', input));
        for (int i = 1; i <= input-2; i++)
        {
            if (i==(input-1)/2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * input-2), new string('|', input));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * input - 2), new string(' ', input));
            }
        }
        Console.WriteLine("{0}{1}{0}", new string('*', 2 * input), new string(' ', input));
    }
}