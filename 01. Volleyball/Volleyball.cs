using System;
class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometown = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Floor((holidays * 2 / 3 + hometown + (48 - hometown) * 3 / 4) * (leap == "leap" ? 1.15 : 1)));
    }
}