using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        Console.WriteLine(holidays / 2 + hometown + (52 - hometown) * 2 / 3 + (leap == "t" ? 3 : 0));
    }
}