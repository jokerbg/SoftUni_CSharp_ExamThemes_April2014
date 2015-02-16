using System;
class Budget
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int weekdays = int.Parse(Console.ReadLine());
        int hometownWE = int.Parse(Console.ReadLine());
        int amount = n - 220 - weekdays * (int)(0.03 * n) - (8 - hometownWE * 2) * 20 - 150;
        if (amount == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (amount > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", amount);
        }
        else
        {
            Console.WriteLine("No, not enough {0}.", -amount);
        }
    }
}