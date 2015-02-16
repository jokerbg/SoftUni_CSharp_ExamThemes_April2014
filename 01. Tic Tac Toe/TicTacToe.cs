using System;
class TicTacToe
{
    static void Main()
    {
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        int value = Int32.Parse(Console.ReadLine());
        int index = y * 3 + x + 1;
        ulong result = (ulong)(Math.Pow(value + index - 1, index));
        Console.WriteLine(result);
    }
}