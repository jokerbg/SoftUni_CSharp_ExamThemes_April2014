using System;
class TheExplorer
{
    static void Main()
    {
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('-', (input - 1) / 2));
        for (int i = 1; i <= input - 2; i += 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', (input - i - 2) / 2), new string('-', i));
        }
        for (int i = input -4; i >0; i -= 2)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', (input - i - 2) / 2), new string('-', i));
        }
        Console.WriteLine("{0}*{0}", new string('-', (input - 1) / 2));
    }
}