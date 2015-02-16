using System;
class PiggyBank
{
    static void Main()
    {
        int tankPrice = Int32.Parse(Console.ReadLine());
        int partyDays = Int32.Parse(Console.ReadLine());

        double neto = (30 - partyDays) * 2 - partyDays * 5;
        if (neto < 0)
        {
            Console.WriteLine("never"); return;
        }
        double totalMonths = Math.Ceiling(tankPrice / neto);
        int years = (int)totalMonths / 12;
        double months = totalMonths - 12 * years;

        Console.WriteLine("{0} years, {1} months", years, months);
    }
}