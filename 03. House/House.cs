using System;
class House
{
    static void Main()
    {
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', (input - 1) / 2));
        for (int i = (input - 3) / 2; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', input - 2 - i * 2));
        }
        Console.WriteLine(new string('*', input));
        for (int i = (input - 3) / 2; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', input / 4), new string('.', input - 2 - input / 4 - input / 4));
        }
        Console.WriteLine("{0}*{1}*{0}", new string('.', input / 4), new string('*', input - 2 - input / 4 - input / 4));
    }
}