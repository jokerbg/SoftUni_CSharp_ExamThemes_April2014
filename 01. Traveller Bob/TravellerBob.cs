using System;
class TravellerBob
{
    static void Main()
    {
        double index = (Console.ReadLine() == "leap") ? 1.05 : 1;
        double contract = Int32.Parse(Console.ReadLine());
        double family = Int32.Parse(Console.ReadLine());
        Console.WriteLine((int)((contract * 12 + family * 4 + (12 - contract - family) * 36 / 5) * index));
    }
}