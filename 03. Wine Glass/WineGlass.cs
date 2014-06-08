using System;
class WineGlass
{
    static void Main()
    {
        int extra = 0;
        int input = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= input / 2; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('.', i - 1), new string('*', input - i * 2));
        }

        extra = (input >= 12) ? input / 2 - 2 : input / 2 - 1;
        for (int i = 1; i <= extra; i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', input / 2 - 1));
        }
        Console.WriteLine(new string('-', input));
        if (input >= 12)
        {
            Console.WriteLine(new string('-', input));
        }
    }
}